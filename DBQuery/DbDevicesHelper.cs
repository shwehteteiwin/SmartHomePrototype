using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SmartHomeSideMenubar.DBQuery
{
    public class DbDevicesHelper
    {

        // Enum for device status
        public enum DeviceStatus
        {
            OFF = 0,
            ON = 1
        }
       // public static void UpdateAllDevicesStatus(DeviceStatus status)
       /* {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Devices SET Status = @Status, Updated = @Updated";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", (int)status);
                    command.Parameters.AddWithValue("@Updated", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }*/
        public static void UpdateAllDevicesStatus(DeviceStatus status)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Devices SET Status = @Status";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", (int)status);
                    command.Parameters.AddWithValue("@Updated", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static (int totalDevices, int openDevices, int closedDevices) GetDeviceCounts()
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Devices; " +
                               "SELECT COUNT(*) FROM Devices WHERE Status = 1; " +  // Assuming 1 is ON
                               "SELECT COUNT(*) FROM Devices WHERE Status = 0;";  // Assuming 0 is OFF

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    int totalDevices = 0, openDevices = 0, closedDevices = 0;

                    if (reader.Read()) totalDevices = reader.GetInt32(0);   // Count all devices
                    if (reader.NextResult() && reader.Read()) openDevices = reader.GetInt32(0);   // Count ON devices
                    if (reader.NextResult() && reader.Read()) closedDevices = reader.GetInt32(0); // Count OFF devices

                    return (totalDevices, openDevices, closedDevices);
                }
            }
        }
        public static Device GetDeviceById(int deviceId)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT DeviceID, DeviceName, Status FROM Devices WHERE DeviceID = @DeviceID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DeviceID", deviceId); // ✅ Correct column name

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Device
                            {
                                Id = reader.GetInt32(0),  // ✅ Change to match DeviceID
                                DeviceName = reader.GetString(1),

                                Status = (DeviceStatus)reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return null;
        }




        // Fetch all devices
        public static List<Device> GetAllDevices()
        {
            List<Device> devices = new List<Device>();
            using (var connection = DbHelper.GetConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    string query = @"SELECT 
                d.DeviceID, 
                d.DeviceName, 
                t.TypeName, 
                g.GroupName, 
                d.IsReal, 
                d.Status,
                d.Created,
                d.Updated
                FROM Devices d
                JOIN Types t ON d.TypeID = t.TypeID
                JOIN Groups g ON d.GroupID = g.GroupID";

                    using (var cmd = new SQLiteCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming status is an integer, map it to the enum
                            int statusInt = reader.GetInt32(5);
                            DeviceStatus status = Enum.IsDefined(typeof(DeviceStatus), statusInt)
                                ? (DeviceStatus)statusInt
                                : DeviceStatus.OFF;

                            devices.Add(new Device
                            {
                                DeviceID = reader.GetInt32(0),
                                DeviceName = reader.GetString(1),
                                TypeName = reader.GetString(2),
                                GroupName = reader.GetString(3),
                                IsReal = reader.GetInt32(4) == 1,  // Convert 0/1 to bool
                                Created = reader.GetDateTime(6).ToLocalTime(),
                                Updated = reader.GetDateTime(7).ToLocalTime(),

                                Status = status
                            });
                        }
                    }
                }
            }
            return devices;
        }
        

        // Get devices by GroupID
        public static List<Device> GetDevicesByGroupID(int groupId)
        {
            return GetDevicesByQuery(@"
                SELECT 
                    d.DeviceID, d.DeviceName, t.TypeName, d.Status, 
                    d.IsReal, g.GroupName, d.Created, d.Updated
                FROM Devices d
                LEFT JOIN Groups g ON d.GroupID = g.GroupID
                LEFT JOIN Types t ON d.TypeID = t.TypeID
                WHERE d.GroupID = @GroupID;", (cmd) =>
            {
                cmd.Parameters.AddWithValue("@GroupID", groupId);
            });
        }
        public static List<Device> GetDevicesByTypeID(int typeId)
        {
            return GetDevicesByQuery(@"
                SELECT 
                    d.DeviceID, d.DeviceName, t.TypeName, d.Status, 
                    d.IsReal , g.GroupName, d.Created, d.Updated
                FROM Devices d
                LEFT JOIN Groups g ON d.GroupID = g.GroupID
                LEFT JOIN Types t ON d.TypeID = t.TypeID
                WHERE d.typeID = @typeID;", (cmd) =>
            {
                cmd.Parameters.AddWithValue("@TypeID", typeId);
            });
        }

        private static List<Device> GetDevicesByQuery(string query, Action<SQLiteCommand> parameterSetter = null)
        {
            List<Device> devices = new List<Device>();
            try
            {
                using (var connection = DbHelper.GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        parameterSetter?.Invoke(command);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DeviceStatus status = (DeviceStatus)reader.GetInt32(3);
                                bool IsReal = reader.GetInt32(4) == 1; // ✅ Fixed

                                devices.Add(new Device
                                {
                                    DeviceID = reader.GetInt32(0),
                                    DeviceName = reader.GetString(1),
                                    TypeName = reader.IsDBNull(2) ? "No Type" : reader.GetString(2),
                                    Status = status,
                                    IsReal = IsReal,  // ✅ Now correctly converted to bool
                                    GroupName = reader.IsDBNull(5) ? "No Group" : reader.GetString(5),
                                    Created = reader.GetDateTime(6),
                                    Updated = reader.GetDateTime(7)
                                });
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Error fetching devices", ex);
            }
            return devices;
        }

        // Add new device
        public static void AddDevice(string deviceName, int typeId, DeviceStatus status, bool IsReal, int groupId)
        {
            ExecuteNonQuery(@"
                INSERT INTO Devices (DeviceName, TypeID, Status, IsReal, GroupID, Created, Updated)
                VALUES (@DeviceName, @TypeID, @Status, @IsReal, @GroupID, @Created, @Updated)", (cmd) =>
            {
                cmd.Parameters.AddWithValue("@DeviceName", deviceName);
                cmd.Parameters.AddWithValue("@TypeID", typeId);
                cmd.Parameters.AddWithValue("@Status", (int)status);
                cmd.Parameters.AddWithValue("@IsReal", IsReal ? 1 : 0);
                cmd.Parameters.AddWithValue("@GroupID", groupId);
                cmd.Parameters.AddWithValue("@Created", DateTime.Now);
                cmd.Parameters.AddWithValue("@Updated", DateTime.Now);
            });
        }

        public static bool UpdateDevice(int deviceId, string deviceName, int typeId, int groupId, bool IsReal)
        {
            try
            {
                // Ensure the type and group exist before updating
                if (GetTypeIDByName(deviceName) == 0 || GetGroupIDByName(deviceName) == 0)
                {
                    Console.WriteLine("Invalid Type or Group.");
                    return false;
                }

                int rowsAffected = ExecuteNonQuery(@"
            UPDATE Devices 
            SET DeviceName = @DeviceName, 
                TypeID = @TypeID, 
                IsReal = @IsReal, 
                GroupID = @GroupID, 
                Updated = @Updated
            WHERE DeviceID = @DeviceID", (cmd) =>
                {
                    cmd.Parameters.AddWithValue("@DeviceID", deviceId);
                    cmd.Parameters.AddWithValue("@DeviceName", deviceName);
                    cmd.Parameters.AddWithValue("@TypeID", typeId);
                    cmd.Parameters.AddWithValue("@IsReal", IsReal ? 1 : 0); // Convert bool to 0/1
                    cmd.Parameters.AddWithValue("@GroupID", groupId);
                    cmd.Parameters.AddWithValue("@Updated", DateTime.Now);
                });

                return rowsAffected > 0; // Return true if at least one row updated
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating device: {ex.Message}");
                return false;
            }
        }
    

        // Update device status
        public static void UpdateDeviceStatus(int deviceID, DeviceStatus newStatus)
        {
            ExecuteNonQuery("UPDATE Devices SET Status = @status, Updated = @updated WHERE DeviceID = @deviceID", (cmd) =>
            {
                cmd.Parameters.AddWithValue("@status", (int)newStatus);
                cmd.Parameters.AddWithValue("@updated", DateTime.Now);
                cmd.Parameters.AddWithValue("@deviceID", deviceID);
            });
        }


        // Delete device
        public static void DeleteDevice(int deviceId)
        {
            ExecuteNonQuery("DELETE FROM Devices WHERE DeviceID = @DeviceID", (cmd) =>
            {
                cmd.Parameters.AddWithValue("@DeviceID", deviceId);
            });
        }

        // ExecuteNonQuery helper

        private static int ExecuteNonQuery(string query, Action<SQLiteCommand> parameterSetter = null)
        {
            try
            {
                using (var connection = DbHelper.GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        parameterSetter?.Invoke(command); // Apply parameters if any
                        return command.ExecuteNonQuery(); // ✅ Return affected rows
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Database operation error", ex);
                return 0; // Return 0 if an error occurs
            }
        }
        public static int GetTypeIDByName(string typeName)
        {
            try
            {
                using (var connection = DbHelper.GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT TypeID FROM Types WHERE TypeName = @TypeName";
                        command.Parameters.AddWithValue("@TypeName", typeName.Trim()); // Trim to remove extra spaces

                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1; // Return -1 if not found
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Error fetching TypeID by name", ex);
                return -1; // Return -1 on error
            }
        }

        public static int GetGroupIDByName(string groupName)
        {
            try
            {
                using (var connection = DbHelper.GetConnection())
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT GroupID FROM Groups WHERE GroupName = @GroupName";
                        command.Parameters.AddWithValue("@GroupName", groupName.Trim());

                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Error fetching GroupID by name", ex);
                return -1;
            }
        }

        public static void UpdateDevicesStatusByGroup(int groupId, int status)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Devices SET Status = @Status WHERE GroupID = @GroupID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateDevicesStatusByType(int typeId, int status)
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Devices SET Status = @Status WHERE TypeID = @TypeID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@TypeID", typeId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteAllDevices()
        {
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Run the DELETE query to remove all groups
                string query = "DELETE FROM Devices";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteSelectedDevices(List<int> deviceIds)
        {
            if (deviceIds == null || deviceIds.Count == 0)
            {
                // No devices to delete, return early
                return;
            }

            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();

                // Prepare the DELETE query with the selected group IDs
                string query = "DELETE FROM Devices WHERE DeviceID IN (" + string.Join(",", deviceIds) + ")";

                // Execute the DELETE query
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool GetDeviceIsReal(int deviceID)
        {
            string query = "SELECT IsReal FROM Devices WHERE DeviceID = @DeviceID";
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DeviceID", deviceID);
                    object result = cmd.ExecuteScalar();
                    return result != null && Convert.ToBoolean(result);
                }
            }
        }

        //Get counts of devices
        public static int GetDeviceCountByGroup(int groupId)
        {
            int count = 0;
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Devices WHERE GroupID = @GroupID";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    object result = command.ExecuteScalar();
                    count = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            return count;
        }
        //get opened devices counts
        public static int GetOpenedDeviceCountByGroup(int groupId)
        {
            int count = 0;
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Devices WHERE GroupID = @GroupID AND Status = 1";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    object result = command.ExecuteScalar();
                    count = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            return count;
        }
        //get closed devices counts
        public static int GetClosedDeviceCountByGroup(int groupId)
        {
            int count = 0;
            using (var connection = DbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Devices WHERE GroupID = @GroupID AND Status = 0";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupID", groupId);
                    object result = command.ExecuteScalar();
                    count = result != null ? Convert.ToInt32(result) : 0;
                }
            }
            return count;
        }
        //toggle changes for all devices status
        public static void UpdateAllDevicesStatusByGroup(int groupId, bool turnOn)
        {
            int status = turnOn ? 1 : 0;            // Adjust status format as needed

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Devices SET Status = @Status WHERE GroupID = @GroupID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@GroupID", groupId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Device> GetOpenedDevicesByGroup(int groupId)
        {
            List<Device> devices = new List<Device>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT DeviceID, DeviceName FROM Devices WHERE GroupID = @GroupID AND Status = 1";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GroupID", groupId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            devices.Add(new Device
                            {
                                DeviceID = reader.GetInt32(0),
                                DeviceName = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return devices;
        }

        // Logging helper
        private static void LogError(string message, Exception ex)
        {
            Console.WriteLine($"[ERROR] {message}: {ex?.Message}");
        }

       

    }
}
