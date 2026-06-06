using System;
using System.Collections.Generic;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar;

namespace SmartHomeSideMenubar.Mqtt
{
    public class MqttHelper
    {
        private MqttClient _client;
        private string _broker = "test.mosquitto.org";  // Broker URL

        public MqttHelper()
        {
            _client = new MqttClient(_broker); // Initialize the client with broker URL
        }

        // Subscribe to a single topic
        public void SubscribeToTopic(string topic)
        {
            if (_client.IsConnected)
            {
                _client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            }
        }

        // Publish a message to a topic
        public void PublishMessage(string topic, string message)
        {
            if (_client.IsConnected)
            {
                _client.Publish(topic, Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
            }
        }

        // Set the message received handler
        public void SetMessageReceivedHandler(Action<string, string> messageHandler)
        {
            _client.MqttMsgPublishReceived += (sender, e) =>
            {
                string topic = e.Topic;
                string message = Encoding.UTF8.GetString(e.Message);

                // Extract device ID from the topic (e.g., home/device/1/status)
                int deviceID = ExtractDeviceIdFromTopic(topic);

                // Pass both topic and message to the handler
                messageHandler?.Invoke(topic, message);
            };
        }

        // Extract the device ID from the topic
        private int ExtractDeviceIdFromTopic(string topic)
        {
            // Example: Extract the device ID from topic like "home/device/1/status"
            var parts = topic.Split('/');
            return int.Parse(parts[2]); // Assuming the device ID is always at this position
        }

        // Generate MQTT topics based on device list
        public List<string> GenerateMqttTopicsForDevices(List<Device> devices)
        {
            List<string> topics = new List<string>();
            foreach (var device in devices)
            {
                string statusTopic = $"home/device/{device.DeviceID}/status";
                topics.Add(statusTopic);

                string controlTopic = $"home/device/{device.DeviceID}/control";
                topics.Add(controlTopic);
            }
            return topics;
        }

        // Subscribe to MQTT topics for all devices
        public void SubscribeToDeviceTopics(List<Device> devices)
        {
            foreach (var device in devices)
            {
                string statusTopic = $"home/device/{device.DeviceID}/status";
                string controlTopic = $"home/device/{device.DeviceID}/control";

                // Subscribe to these topics
                SubscribeToTopic(statusTopic);
                SubscribeToTopic(controlTopic);
            }
        }

        // Publish a message to control a device
        public void PublishControlMessage(int deviceId, string action)
        {
            string controlTopic = $"home/device/{deviceId}/control";
            PublishMessage(controlTopic, action);
        }

        // Property to check if the client is connected
        public bool IsConnected
        {
            get
            {
                return _client != null && _client.IsConnected;
            }
        }

        // Method to connect to the MQTT broker
        public bool Connect()
        {
            try
            {
                if (!_client.IsConnected) // Check if already connected
                {
                    string clientId = Guid.NewGuid().ToString();
                    _client.Connect(clientId);  // Connect using clientId
                }

                return _client.IsConnected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
                return false;
            }
        }

        // Method to disconnect from the MQTT broker
        public void Disconnect()
        {
            if (_client != null && _client.IsConnected)
            {
                _client.Disconnect();
            }
        }

        // Ensure connection to the broker
        public bool EnsureConnection()
        {
            if (!_client.IsConnected)
            {
                string clientId = Guid.NewGuid().ToString();
                _client.Connect(clientId);  // Ensure the client is connected
            }
            return _client.IsConnected;
        }
    }
}
