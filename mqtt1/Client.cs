using MQTTnet;
using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt1
{
    public partial class Frm_Client : Form
    {
        public Frm_Client()
        {
            InitializeComponent();
        }

        private void btnGoServer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private IMqttClient mqttClient;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            mqttClient = new MqttFactory().CreateMqttClient();
            var option = new MqttClientOptions() { ClientId = Guid.NewGuid().ToString("D") };
            option.ChannelOptions = new MqttClientTcpOptions()
            {
                Server=this.txtClientIp.Text,
                Port=Convert.ToInt32(this.txtClientPort.Text)
            };

            option.Credentials = new MqttClientCredentials()
            {
                Username = this.txtUsername.Text,
                Password = this.txtPwd.Text
            };
            option.CleanSession = true;
            option.KeepAlivePeriod = TimeSpan.FromSeconds(100);
            option.KeepAliveSendInterval = TimeSpan.FromSeconds(100);
            mqttClient.Connected += MqttClient_Connected;
            mqttClient.Disconnected += MqttClient_Disconnected;
            mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
            mqttClient.ConnectAsync(option);
            publishTimer.Enabled = true;
            publishTimer.Start();
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MqttClient_Disconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            MessageBox.Show("断开连接");
            
        }

        private void MqttClient_Connected(object sender, MqttClientConnectedEventArgs e)
        {

            MessageBox.Show("连接成功");
           
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            mqttClient.DisconnectAsync();
            publishTimer.Enabled = false;
            publishTimer.Stop();
        }

        private void publishTimer_Tick(object sender, EventArgs e)
        {
            if (mqttClient.IsConnected)
            {
                var msg = new MqttApplicationMessage()
                {
                    Topic = "童老弟",
                    Payload = Encoding.UTF8.GetBytes(DateTime.Now.Second.ToString()),
                    QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce,
                    Retain = false
                };
                mqttClient.PublishAsync(msg);
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (mqttClient.IsConnected)
            {
                var msg = new MqttApplicationMessage()
                {
                    Topic = "童老弟",
                    Payload = Encoding.UTF8.GetBytes(DateTime.Now.Second.ToString()),
                    QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce,
                    Retain = true
                };
                mqttClient.PublishAsync(msg);
            }
        }
    }
}
