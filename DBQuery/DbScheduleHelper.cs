using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SmartHomeSideMenubar.DBQuery;

public class DbScheduleHelper
{
    // Enum for device status
    public enum DeviceStatus
    {
        OFF = 0,
        ON = 1
    }
    public static void ExecuteNonQuery(string query, Action<SQLiteCommand> parameterSetter)
    {
        using (var conn = DbHelper.GetConnection()) // Use centralized connection
        {
            conn.Open();
            using (var cmd = new SQLiteCommand(query, conn))
            {
                parameterSetter(cmd);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to add a new schedule
    public static void AddSchedule(int deviceID, DeviceStatus status, DateTime startTime, DateTime endTime, string repeatDays)
    {
        ExecuteNonQuery(@"
        INSERT INTO Schedules (DeviceID, Status, StartTime, EndTime, RepeatDays) 
        VALUES (@DeviceID, @Status, @StartTime, @EndTime, @RepeatDays)", (cmd) =>
        {
            cmd.Parameters.AddWithValue("@DeviceID", deviceID);
            cmd.Parameters.AddWithValue("@Status", (int)status);
            cmd.Parameters.AddWithValue("@StartTime", startTime.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@EndTime", endTime.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("@RepeatDays", repeatDays);
        });
    }
    // Method to retrieve all schedules with device names
    public static List<Dictionary<string, object>> GetSchedules()
    {
        List<Dictionary<string, object>> schedules = new List<Dictionary<string, object>>();

        using (var conn = DbHelper.GetConnection())
        {
            conn.Open();
            string query = @"
         SELECT s.ScheduleID, s.DeviceID, d.DeviceName, s.Status, s.StartTime, s.EndTime, s.RepeatDays
         FROM Schedules s
         INNER JOIN Devices d ON s.DeviceID = d.DeviceID
         ORDER BY s.StartTime;";

            using (var cmd = new SQLiteCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var schedule = new Dictionary<string, object>
                    {
                        ["ScheduleID"] = reader["ScheduleID"],
                        ["DeviceID"] = reader["DeviceID"],
                        ["DeviceName"] = reader["DeviceName"],
                        ["Status"] = reader["Status"],
                        ["StartTime"] = reader["StartTime"],
                        ["EndTime"] = reader["EndTime"],
                        ["RepeatDays"] = reader["RepeatDays"]
                    };
                    schedules.Add(schedule);
                }
            }
        }

        return schedules;
    }

    // Method to retrieve all schedules
    //public static List<Dictionary<string, object>> GetSchedules()
    //{
    //    List<Dictionary<string, object>> schedules = new List<Dictionary<string, object>>();

    //    using (var conn = DbHelper.GetConnection())
    //    {
    //        conn.Open();
    //        string query = "SELECT * FROM Schedules;";

    //        using (var cmd = new SQLiteCommand(query, conn))
    //        using (var reader = cmd.ExecuteReader())
    //        {
    //            while (reader.Read())
    //            {
    //                var schedule = new Dictionary<string, object>
    //                {
    //                    ["ScheduleID"] = reader["ScheduleID"],
    //                    ["DeviceID"] = reader["DeviceID"],
    //                    ["Status"] = reader["Status"],
    //                    ["StartTime"] = reader["StartTime"],
    //                    ["EndTime"] = reader["EndTime"],
    //                    ["RepeatDays"] = reader["RepeatDays"]
    //                };
    //                schedules.Add(schedule);
    //            }
    //        }
    //    }

    //    return schedules;
    //}


}
