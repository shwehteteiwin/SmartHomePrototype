using SmartHomeSideMenubar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SmartHomeSideMenubar.DBQuery
{
    public class DbGroupHelper
    {
        public static List<(int, string, DateTime, DateTime)> GetGroups() 
        {
            List<(int, string, DateTime, DateTime)> groups = new(); 

            try
            {
                using (var connection = DbHelper.GetConnection() ?? throw new InvalidOperationException("Failed to get a database connection"))
                {
                    connection.Open();
                    using (var command = new SQLiteCommand("SELECT GroupID, GroupName, CreatedAt, UpdatedAt FROM Groups", connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int groupId = reader.GetInt32(0);
                            string groupName = reader.IsDBNull(1) ? "Unnamed Group" : reader.GetString(1);
                            DateTime createdAt = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2);
                            DateTime updatedAt = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3);

                            groups.Add((groupId, groupName, createdAt, updatedAt)); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }

            return groups;
        
        }


        public static void AddGroup(string groupName)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Groups (GroupName,CreatedAt, UpdatedAt) VALUES (@GroupName,@Created, @Updated)", connection))
                {
                    command.Parameters.AddWithValue("@GroupName", groupName);
                    command.Parameters.AddWithValue("@Created",DateTime.Now);
                    command.Parameters.AddWithValue("@Updated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateGroup(int groupId, string newGroupName)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Groups SET GroupName = @GroupName, UpdatedAt = @Updated WHERE GroupID = @GroupID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    command.Parameters.AddWithValue("@GroupName", newGroupName);
                    command.Parameters.AddWithValue("@Updated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteGroup(int groupId)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Check if the group exists before deleting
                string checkQuery = "SELECT COUNT(*) FROM Groups WHERE GroupID = @GroupID";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@GroupID", groupId);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count == 0)
                    {
                        throw new Exception("Group not found.");
                    }
                }

                // Run the DELETE query
                string query = "DELETE FROM Groups WHERE GroupID = @GroupID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // New method to delete all groups
        public static void DeleteAllGroups()
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Run the DELETE query to remove all groups
                string query = "DELETE FROM Groups";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to delete multiple selected groups based on their IDs
        public static void DeleteSelectedGroups(List<int> groupIds)
        {
            if (groupIds == null || groupIds.Count == 0)
            {
                // No groups to delete, return early
                return;
            }

            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Prepare the DELETE query with the selected group IDs
                string query = "DELETE FROM Groups WHERE GroupID IN (" + string.Join(",", groupIds) + ")";

                // Execute the DELETE query
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        // Fetch all groups
        public static List<Group> GetAllGroups()
        {
            List<Group> groups = new List<Group>();
            try
            {
                using (var connection = DbHelper.GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT GroupID, GroupName FROM Groups;";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                groups.Add(new Group
                                {
                                    GroupID = reader.GetInt32(0),
                                    GroupName = reader.GetString(1)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Error fetching groups", ex);
            }
            return groups;
        }

        public static bool IsGroupOn(int groupId)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Devices WHERE GroupID = @GroupID AND Status = 1";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    int onCount = Convert.ToInt32(command.ExecuteScalar());
                    return onCount > 0; // If at least one device is ON, return true
                }
            }
        }

        private static void LogError(string message, Exception ex)
        {
            Console.WriteLine($"[ERROR] {message}: {ex?.Message}");
        }

    }
}
