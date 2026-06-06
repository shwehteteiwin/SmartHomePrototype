using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSideMenubar.DBQuery
{
    public class DbHelper
    {
        private static string dbFilePath = "Smart_Home_Db.sqlite";
        private static string connectionString = $"Data Source={dbFilePath};Version=3;";

        // Function to establish connection to the SQLite database
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Function to create database if it doesn't exist
        public static void CreateDatabase()
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
                Console.WriteLine("Database created successfully.");
            }
        }

        // Function to create tables if they don't exist
        public static void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
CREATE TABLE IF NOT EXISTS Users (
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE,
    Password TEXT NOT NULL,
    Email TEXT NOT NULL UNIQUE,
    Role TEXT NOT NULL CHECK (Role IN ('Admin', 'User')),
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    Photo BLOB
);

CREATE TABLE IF NOT EXISTS OTP_Store (
    OTP_ID INTEGER PRIMARY KEY AUTOINCREMENT,
    UserID INTEGER NOT NULL,
    OTP_Code TEXT NOT NULL,
    ExpiryTime DATETIME NOT NULL,
    Used INTEGER DEFAULT 0 CHECK (Used IN (0, 1)),
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Groups (
    GroupID INTEGER PRIMARY KEY AUTOINCREMENT,
    GroupName TEXT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS Types (
    TypeID INTEGER PRIMARY KEY AUTOINCREMENT,
    TypeName TEXT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Devices (
    DeviceID INTEGER PRIMARY KEY AUTOINCREMENT,
    DeviceName TEXT NOT NULL,
    TypeID INTEGER DEFAULT 0 NOT NULL,
    Status INTEGER CHECK (Status IN (0, 1)) DEFAULT 0,
    IsReal INTEGER NOT NULL DEFAULT 0 CHECK (IsReal IN (0, 1)),
    GroupID INTEGER DEFAULT 0 NOT NULL, 
    Created DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (GroupID) REFERENCES Groups(GroupID),
    FOREIGN KEY (TypeID) REFERENCES Types(TypeID)
);




CREATE TABLE IF NOT EXISTS Configuration (
    ConfigurationID INTEGER PRIMARY KEY AUTOINCREMENT,
    DeviceID INTEGER,
    SettingName TEXT NOT NULL,
    SettingValue TEXT NOT NULL,
    LastUpdated DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (DeviceID) REFERENCES Devices(DeviceID)
);

CREATE TABLE IF NOT EXISTS Schedules (
    ScheduleID INTEGER PRIMARY KEY AUTOINCREMENT,
    DeviceID INTEGER,
    Status TEXT NOT NULL DEFAULT '0' CHECK (Status IN ('0', '1')),
    StartTime DATETIME DEFAULT CURRENT_TIMESTAMP,
    EndTime DATETIME DEFAULT CURRENT_TIMESTAMP,
    RepeatDays TEXT DEFAULT 'None',
    FOREIGN KEY (DeviceID) REFERENCES Devices(DeviceID)
);

CREATE TABLE IF NOT EXISTS Logs (
    LogID INTEGER PRIMARY KEY AUTOINCREMENT,
    DeviceID INTEGER,
    GroupID INTEGER,
    Action TEXT NOT NULL CHECK (Action IN ('ON', 'OFF')),
    TriggeredBy TEXT NOT NULL CHECK (TriggeredBy IN ('User', 'Schedule', 'System', 'MQTT')),
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    Status TEXT NOT NULL CHECK (Status IN ('Success', 'Failed')),
    ErrorMessage TEXT DEFAULT NULL,
    FOREIGN KEY (DeviceID) REFERENCES Devices(DeviceID),
    FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)
);

CREATE TABLE IF NOT EXISTS Alerts (
    AlertID INTEGER PRIMARY KEY AUTOINCREMENT,
    DeviceID INTEGER,
    GroupID INTEGER,
    AlertType TEXT NOT NULL,
    Message TEXT NOT NULL,
    Severity TEXT NOT NULL CHECK (Severity IN ('Low', 'Medium', 'High', 'Critical')),
    Status TEXT NOT NULL CHECK (Status IN ('New', 'Acknowledged', 'Resolved')),
    TriggeredAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    ResolvedAt DATETIME DEFAULT NULL,
    FOREIGN KEY (DeviceID) REFERENCES Devices(DeviceID),
    FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)
);
CREATE TABlE IF NOT EXISTS History (
                       HistoryID INTEGER PRIMARY KEY AUTOINCREMENT,
                       HistoryName  TEXT NOT NULL,
                       CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                     );
";

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
