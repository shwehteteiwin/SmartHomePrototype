using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using BC = BCrypt.Net.BCrypt;
using SmartHomeSideMenubar.Welcome;
using Microsoft.VisualBasic.ApplicationServices;




namespace SmartHomeSideMenubar.DBQuery
{
    public class DbUserHelper
    {
        private static SQLiteConnection connection;

        public static object BCrypt { get; private set; }

        // Initialize and open a single connection
        public static void OpenConnection()
        {
            if (connection == null)
            {
                connection = DbHelper.GetConnection();
                connection.Open();
            }
        }

        // Close the connection when done
        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

        // Get user details by UserID
        public static (string UserName, string Email, string Password, string Role, DateTime CreatedAt, DateTime UpdatedAt) GetUserById(int userId)
        {
            OpenConnection();

            string userName = null;
            string email = null;
            string password = null;
            string role = null;
            DateTime createdAt = default;
            DateTime updatedAt = default;

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
            SELECT UserName, Email, Password, Role, CreatedAt, UpdatedAt 
            FROM Users 
            WHERE UserID = @userId";

                command.Parameters.AddWithValue("@userId", userId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userName = reader.GetString(0);
                        email = reader.GetString(1);
                        password = reader.GetString(2); // Now fetching password
                        role = reader.GetString(3);
                        createdAt = reader.GetDateTime(4);
                        updatedAt = reader.GetDateTime(5);
                    }
                }
            }

            return (userName, email, password, role, createdAt, updatedAt);
        }


        // Insert a new user into the Users table
        public static bool InsertUser(string username, string email, string password, string role)
        {
            OpenConnection();

            // Check if there are any users in the database
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT COUNT(*) FROM Users";
                int userCount = Convert.ToInt32(command.ExecuteScalar());

                // First user should be Admin
                if (userCount == 0)
                {
                    role = "Admin";
                }

                // Hash the password before storing
                string hashedPassword = BC.HashPassword(password);

                // Insert user into database
                command.CommandText = @"
            INSERT INTO Users (UserName, Email, Password, Role, CreatedAt, UpdatedAt) 
            VALUES (@UserName, @Email, @Password, @Role, @CreatedAt, @UpdatedAt)";

                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", hashedPassword);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);
                command.Parameters.AddWithValue("@UpdatedAt", DateTime.UtcNow);

                return command.ExecuteNonQuery() > 0;
            }
        }

       
        public static string GetUserRoleByEmail(string email)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT Role FROM Users WHERE Email = @Email";
                command.Parameters.AddWithValue("@Email", email);

                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : "User"; // Default to "User" if no result
            }
        }

        public static int GetUserIdByEmail(string email)
        {
            OpenConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT UserID FROM Users WHERE Email = @Email";
                command.Parameters.AddWithValue("@Email", email);
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }


        public static int AuthenticateUser(string email, string password)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT UserID, Password FROM Users WHERE Email = @Email";
                command.Parameters.AddWithValue("@Email", email);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string storedHash = reader.GetString(1);

                        if (BC.Verify(password, storedHash)) // Checking hashed password
                        {
                            return userId; // Successful authentication
                        }
                    }
                }
            }
            return -1; // Authentication failed
        }



        // Update an existing user's details
        public static bool UpdateUser(int userId, string userName, string email, string role, string newPassword = null)
        {
            OpenConnection();
            using (var command = connection.CreateCommand())
            {
                // Base query without password update
                string query = @"
            UPDATE Users 
            SET UserName = @userName, 
                Email = @email, 
                Role = @role, 
                UpdatedAt = @updatedAt";

                // If a new password is provided, add it to the query
                if (!string.IsNullOrEmpty(newPassword))
                {
                    query += ", Password = @password";
                }

                query += " WHERE UserID = @userId";

                command.CommandText = query;
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@updatedAt", DateTime.UtcNow);

                // Hash and update the password only if a new one is provided
                if (!string.IsNullOrEmpty(newPassword))
                {
                    string hashedPassword = BC.HashPassword(newPassword);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                }

                return command.ExecuteNonQuery() > 0;
            }
        }


        public static bool DeleteUser(int userId)
        {
            try
            {
                OpenConnection();  

                using (var command = connection.CreateCommand())
                {
                    
                    command.CommandText = "DELETE FROM Users WHERE UserID = @userId";

                   
                    command.Parameters.AddWithValue("@userId", userId);

                    
                    int rowsAffected = command.ExecuteNonQuery();

                   
                    return rowsAffected > 0;
                }
            }
            catch (SQLiteException sqlEx)
            {
          
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Catch any other generic exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool IsEmailExists(string email)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
            SELECT COUNT(1)
            FROM Users
            WHERE Email = @Email";

                command.Parameters.AddWithValue("@Email", email);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
        public static string GetEmailByUserId(int userId)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"
        SELECT Email
        FROM Users
        WHERE UserID = @UserID
        LIMIT 1";

                command.Parameters.AddWithValue("@UserID", userId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(0); // Get the email from the result
                    }
                }
            }
            return string.Empty; // Return an empty string if no email is found
        }
        public static bool UpdatePassword(int userId, string newPassword)
        {
            OpenConnection();
            using (var command = connection.CreateCommand())
            {
               
                command.CommandText = @"
            UPDATE Users 
            SET Password = @password, 
                UpdatedAt = @updatedAt 
            WHERE UserID = @userId";

                // Hash the new password using BCrypt
                string hashedPassword = BC.HashPassword(newPassword);

               
                command.Parameters.AddWithValue("@password", hashedPassword);
                command.Parameters.AddWithValue("@updatedAt", DateTime.UtcNow);
                command.Parameters.AddWithValue("@userId", userId);

                // Execute the query and return true if at least one row was affected
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static byte[] GetUserProfilePhoto(int userId)
        {
            byte[] imageData = null;

            OpenConnection(); 

            using (var command = connection.CreateCommand()) 
            {
                command.CommandText = "SELECT Photo FROM Users WHERE UserID = @UserId";
                command.Parameters.AddWithValue("@UserId", userId);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    imageData = (byte[])result;
                }
            }

            CloseConnection(); 

            return imageData;
        }
        public static bool SaveProfilePhoto(int userId, string filePath)
        {
            byte[] imageBytes = File.ReadAllBytes(filePath);

            OpenConnection(); 

            string query = "UPDATE Users SET Photo = @Photo WHERE UserID = @UserId";
            using (SQLiteCommand cmd = new SQLiteCommand(query, connection)) // Use the shared connection
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Photo", imageBytes);

                bool isSuccess = cmd.ExecuteNonQuery() > 0;
                CloseConnection(); 
                return isSuccess;
            }
        }
        public static bool UpdateUserProfile(int userId,string newName, string newEmail)
        {
            try
            {
                OpenConnection(); 

                string query = "UPDATE Users SET Username = @Username, Email = @Email  WHERE UserID = @UserId";
                using (SQLiteCommand command = new SQLiteCommand(query, connection)) // Use the shared connection
                {
                    command.Parameters.AddWithValue("@Username", newName);
                    command.Parameters.AddWithValue("@Email", newEmail);
                    command.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if the update was successful
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating profile: " + ex.Message);
                CloseConnection(); 
                return false;
            }
        }
        public static User GetUserByEmail(string email)
        {
            User user = null;

            OpenConnection();

            try
            {
                using (var command = connection.CreateCommand()) 
                {
                    command.CommandText = "SELECT UserID, Username, Email, Role FROM Users WHERE Email = @Email LIMIT 1";
                    command.Parameters.AddWithValue("@Email", email);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),   
                                Username = reader.GetString(reader.GetOrdinal("Username")), 
                                Email = reader.GetString(reader.GetOrdinal("Email")),  
                                Role = reader.GetString(reader.GetOrdinal("Role"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection(); 
            }

            return user;
        }

        public class User
        {
            public int UserID { get; set; } // Matches UserID
            public string Username { get; set; } // Matches Username
            public string Email { get; set; } // Matches Email
            public string? Id { get; internal set; }
            public string? Role { get; internal set; }
        }
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            OpenConnection();
            using (var command = connection.CreateCommand())
            {

                command.CommandText  = "SELECT UserID, Username, Email, Role FROM Users";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = reader["UserID"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            Role = reader["Role"].ToString()
                        });
                    }
                }
            }

            return users;
        }
        public static void UpdateUserRole(string userId, string newRole)
        {
            OpenConnection();
            using (var command = connection.CreateCommand())
            {

               
               
                
                    command.CommandText = "UPDATE Users SET Role = @role WHERE UserID = @id";
                    command.Parameters.AddWithValue("@role", newRole);
                    command.Parameters.AddWithValue("@id", userId);
                    command.ExecuteNonQuery();
                
            }
        }
        public static void DeleteUsers(string userId)
        {
            OpenConnection();
            using (var command = connection.CreateCommand())
            {

              
                
                    command.CommandText = "DELETE FROM Users WHERE UserID = @id";
                    command.Parameters.AddWithValue("@id", userId);
                    command.ExecuteNonQuery();
                
            }
        }




    }
}