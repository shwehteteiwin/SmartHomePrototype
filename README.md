# SmartHomePrototype

SmartHomePrototype is a .NET-based backend/desktop application designed for smart home automation and device management. The system utilizes MQTT for lightweight machine-to-machine communication, allowing for seamless integration and control of various smart home controllers and devices.

## 🚀 Features

- **Smart Device Control:** Modular system layout to handle various IoT controls and components.
- **MQTT Integration:** Real-time messaging and data transfer between the application and smart home hardware.
- **Database Integration:** Built-in support for executing structured database queries (`DBQuery`) to log system state and device telemetry.
- **User Session Management:** Safe tracking of active user sessions (`UserSession.cs`).
- **Custom UI Architecture:** Organized into `MainForms` and `SideForms` for a responsive user dashboard experience.

---

## 📂 Project Structure

Based on the core layout of the repository:

- **`Controls/`** - Custom UI elements or hardware interface controls.
- **`DBQuery/`** - Database connection files and telemetry logging queries.
- **`Forms/`, `MainForms/`, `SideForms/`** - Frontend application layouts and menu structures (including `SideMenuBar`).
- **`Models/`** - Data models representing system state, devices, and users.
- **`Mqtt/`** - Protocols and handlers for handling MQTT publisher/subscriber connections.

---

## 🛠️ Prerequisites & Setup

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (Compatible version for your `.csproj`)
- An MQTT Broker (e.g., HiveMQ, Mosquitto)

### Installation

1. Clone the repository to your local machine:

```bash
   git clone [https://github.com/shwehteteiwin/SmartHomePrototype.git](https://github.com/shwehteteiwin/SmartHomePrototype.git)

2. Open the project folder in Visual Studio or VS Code.

3. Restore dependencies and build the project:

```bash
   dotnet restore
   dotnet build

⚙️ Configuration
Before running the application, ensure you configure your local settings:

1. Open Settings.settings to verify your target database connection strings.

2. Check the Mqtt/ setup file to point to your designated MQTT broker host address.