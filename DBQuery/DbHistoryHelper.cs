using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHomeSideMenubar.DBQuery;

namespace SmartHomeSideMenubar.DBQuery
{
    public class DbHistoryHelper
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
        public static void DeleteAllHistory()
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM History";
                    command.ExecuteNonQuery();
                }
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
        public static void InsertHistory(string HistoryName)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO History (HistoryName) VALUES (@HistoryName)";

                command.Parameters.AddWithValue("@HistoryName", HistoryName);
                command.ExecuteNonQuery();

            }
        }

        // Retrieve all history records as a list.
        public static List<HistoryRecord> GetAllHistory()
        {
            List<HistoryRecord> historyList = new List<HistoryRecord>();

            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT HistoryID, HistoryName, CreatedAt FROM History ORDER BY HistoryID DESC";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistoryRecord record = new HistoryRecord
                        {
                            HistoryID = reader.GetInt32(0),
                            HistoryName = reader.GetString(1),
                            CreatedAt = reader.GetDateTime(2).ToLocalTime(),
                        };
                        historyList.Add(record);
                    }
                }

            }
            return historyList;
        }
        public static void DeleteHistory(int HistoryId)
        {
            OpenConnection();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM History WHERE HistoryID = @HistoryID";

                command.Parameters.AddWithValue("@HistoryID", HistoryId);
                command.ExecuteNonQuery();

            }
        }
        // Simple model class for a History record.
        public class HistoryRecord
        {
            public int HistoryID { get; set; }
            public string HistoryName { get; set; }
            public DateTime CreatedAt { get; set; }
        }
    }
}
