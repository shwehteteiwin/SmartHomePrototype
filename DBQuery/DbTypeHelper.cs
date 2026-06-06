using SmartHomeSideMenubar.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSideMenubar.DBQuery
{
    public class DbTypeHelper
    {
        public static List<(int, string, DateTime, DateTime)> GetTypes()
        {
            List<(int, string, DateTime, DateTime)> types = new();

            try
            {
                using (var connection = DbHelper.GetConnection() ?? throw new InvalidOperationException("Failed to get a database connection"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT TypeID, TypeName, CreatedAt, UpdatedAt FROM Types", connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int typeId = reader.GetInt32(0);
                            string typeName = reader.IsDBNull(1) ? "Unnamed Type" : reader.GetString(1);
                            DateTime createdAt = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2);
                            DateTime updatedAt = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);

                            types.Add((typeId, typeName, createdAt, updatedAt));
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }

            return types;

        }


        public static void AddType(string typeName)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Types (TypeName,CreatedAt, UpdatedAt) VALUES (@TypeName,@Created, @Updated)", connection))
                {
                    command.Parameters.AddWithValue("@TypeName", typeName);
                    command.Parameters.AddWithValue("@Created", DateTime.Now);
                    command.Parameters.AddWithValue("@Updated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateType(int typeId, string newTypeName)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Types SET TypeName = @TypeName, UpdatedAt = @Updated WHERE TypeID = @TypeID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeID", typeId);
                    command.Parameters.AddWithValue("@TypeName", newTypeName);
                    command.Parameters.AddWithValue("@Updated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }


        public static void DeleteType(int typeId)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Check if the type exists before deleting
                string checkQuery = "SELECT COUNT(*) FROM Types WHERE TypeID = @TypeID";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TypeID", typeId);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count == 0)
                    {
                        throw new Exception("Types not found.");
                    }
                }

                // Run the DELETE query
                string query = "DELETE FROM Types WHERE TypeID = @TypeID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeID", typeId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // New method to delete all groups
        public static void DeleteAllTypes()
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Run the DELETE query to remove all groups
                string query = "DELETE FROM Types";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to delete multiple selected groups based on their IDs
        public static void DeleteSelectedTypes(List<int> typeIds)
        {
            if (typeIds == null || typeIds.Count == 0)
            {
                // No groups to delete, return early
                return;
            }

            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Prepare the DELETE query with the selected group IDs
                string query = "DELETE FROM Types WHERE TypeID IN (" + string.Join(",", typeIds) + ")";

                // Execute the DELETE query
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    
            private static object message;

        // Fetch all device types
        public static List<TypeModel> GetAllTypes()
        {
            List<TypeModel> types = new List<TypeModel>();
            try
            {
                using (var connection = DbHelper.GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT TypeID, TypeName FROM Types;";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                types.Add(new TypeModel
                                {
                                    TypeID = reader.GetInt32(0),
                                    TypeName = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Error fetching types", ex);
            }
            return types;
        }


        public static bool IsTypeOn(int typeId)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Devices WHERE TypeID = @TypeID AND Status = 1";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeID", typeId);
                    int onCount = Convert.ToInt32(command.ExecuteScalar());
                    return onCount > 0; // If at least one device is ON, return true
                }
            }
        }
        private static void LogError(string v, Exception ex)
        {

            Console.WriteLine($"[ERROR] {message}: {ex?.Message}");
        }

    }
}

