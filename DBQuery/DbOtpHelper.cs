using System;
using System.Data.SQLite;

namespace SmartHomeSideMenubar.DBQuery
{
    public class DbOtpHelper
    {
        private static SQLiteConnection connection;


        public static void OpenConnection()
        {
            if (connection == null)
            {
                connection = DbHelper.GetConnection();
                connection.Open();
            }
        }

       
        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

        
      
        public static bool InsertOTP(int userId, string otpCode, DateTime expiryTime, out int otpId)
        {
            OpenConnection();
            otpId = 0; 

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
            INSERT INTO OTP_Store (UserID, OTP_Code, ExpiryTime, Used, CreatedAt)
            VALUES (@UserID, @OTP_Code, @ExpiryTime, 0, @CreatedAt);
             SELECT last_insert_rowid();";  // Get the inserted OTP_ID

                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@OTP_Code", otpCode);
                command.Parameters.AddWithValue("@ExpiryTime", expiryTime);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);

                // Execute the command and get the OTP_ID
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    otpId = Convert.ToInt32(result);
                    return true;
                }

                return false;
            }
        }


        /// <summary>
        /// Retrieves the most recent OTP record for the given user.
        /// </summary>
        /// <param name="userId">User ID to search OTP records for.</param>
        /// <returns>
        /// A tuple containing OTP_ID, UserID, OTP_Code, ExpiryTime, Used, and CreatedAt if found;
        /// otherwise, null.
        /// </returns>
        public static (int OTP_ID, int UserID, string OTP_Code, DateTime ExpiryTime, int Used, DateTime CreatedAt)? GetLatestOTPByUserId(int userId)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
                    SELECT OTP_ID, UserID, OTP_Code, ExpiryTime, Used, CreatedAt
                    FROM OTP_Store
                    WHERE UserID = @UserID
                    ORDER BY CreatedAt DESC
                    LIMIT 1";
                command.Parameters.AddWithValue("@UserID", userId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int otpId = reader.GetInt32(0);
                        int dbUserId = reader.GetInt32(1);
                        string otpCode = reader.GetString(2);
                        DateTime expiryTime = reader.GetDateTime(3);
                        int used = reader.GetInt32(4);
                        DateTime createdAt = reader.GetDateTime(5);

                        return (otpId, dbUserId, otpCode, expiryTime, used, createdAt);
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Marks the OTP record as used.
        /// </summary>
        /// <param name="otpId">The ID of the OTP record to update.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public static bool MarkOTPAsUsed(int otpId)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
                    UPDATE OTP_Store
                    SET Used = 1
                    WHERE OTP_ID = @otpId";
                command.Parameters.AddWithValue("@otpId", otpId);

                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Validates an OTP for a given user.
        /// Checks if the OTP exists, is not yet used, and is not expired.
        /// If valid, marks the OTP as used.
        /// </summary>
        /// <param name="userId">User ID associated with the OTP.</param>
        /// <param name="otpCode">The OTP code to validate.</param>
        /// <returns>True if the OTP is valid; otherwise, false.</returns>
        public static bool ValidateOTP(int userId, string otpEntered)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
            SELECT OTP_ID, ExpiryTime, Used
            FROM OTP_Store
            WHERE UserID = @UserID AND OTP_Code = @OTP_Code
            ORDER BY CreatedAt DESC
            LIMIT 1";
                command.Parameters.AddWithValue("@UserID", userId);
                command.Parameters.AddWithValue("@OTP_Code", otpEntered);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int otpId = reader.GetInt32(0);
                        DateTime expiryTime = reader.GetDateTime(1);
                        int used = reader.GetInt32(2);

                        // OTP is valid if it has not been used and is still within the expiry time.
                        if (used == 0 && expiryTime > DateTime.UtcNow)
                        {
                            reader.Close(); // Close the reader before executing another command.
                            return MarkOTPAsUsed(otpId);
                        }
                    }
                }
            }
            return false;
        }
       


    }
}

