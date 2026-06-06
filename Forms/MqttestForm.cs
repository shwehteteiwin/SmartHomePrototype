using System;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartHomeSideMenubar.Forms
{
    public partial class MqttestForm : Form
    {
        private MqttClient _client;
        private string _broker = "test.mosquitto.org";
        private int _port = 1883;
        private string _topic = "home/devices/1/status";

        public MqttestForm()
        {
            InitializeComponent();
            InitializeMqtt();
        }

        private void InitializeMqtt()
        {
            try
            {
                _client = new MqttClient(_broker);
                _client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                _client.ConnectionClosed += Client_ConnectionClosed;

                string clientId = Guid.NewGuid().ToString();
                _client.Connect(clientId);

                if (_client.IsConnected)
                {
                    lstMessages.Items.Add("Connected to MQTT broker!");
                    _client.Subscribe(new string[] { _topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                    lstMessages.Items.Add($"Subscribed to {_topic}");
                }
                else
                {
                    lstMessages.Items.Add("Failed to connect!");
                }
            }
            catch (Exception ex)
            {
                lstMessages.Items.Add("Error: " + ex.Message);
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Message);
            BeginInvoke(new Action(() => lstMessages.Items.Add($"Received: {message}")));
        }

        private void Client_ConnectionClosed(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => lstMessages.Items.Add("Disconnected! Attempting to reconnect...")));
            ReconnectMqtt();
        }

        private void ReconnectMqtt()
        {
            while (!_client.IsConnected)
            {
                try
                {
                    string clientId = Guid.NewGuid().ToString();
                    _client.Connect(clientId);
                    lstMessages.Items.Add("Reconnected to MQTT broker!");
                    _client.Subscribe(new string[] { _topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                    break;
                }
                catch
                {
                    System.Threading.Thread.Sleep(5000); // Retry every 5 seconds
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_client.IsConnected)
            {
                string message = txtMessage.Text;
                _client.Publish(_topic, Encoding.UTF8.GetBytes(message));
                lstMessages.Items.Add($"Sent: {message}");
            }
            else
            {
                MessageBox.Show("Not connected to broker!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
