using MQTTnet.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mqtt1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            var Ips = Dns.GetHostAddressesAsync(Dns.GetHostName());
            List<string> IpList = new List<string>();
            foreach (var ip in Ips.Result)
            {
                switch (ip.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                        if (!IpList.Contains(ip.ToString()))
                        {
                            IpList.Add(ip.ToString());
                        }
                        break;
                    default:
                        break;
                }
            }

            if (IpList.Count > 0)
            {
                this.cmbIP.DataSource = IpList;
                this.cmbIP.SelectedIndex = 0;
            }

        }


        private IMqttServer mqttServer;

        private void btnStart_Click(object sender, EventArgs e)
        {
            mqttServer = new MQTTnet.MqttFactory().CreateMqttServer();
            var OptionBuilder = new MqttServerOptionsBuilder();
            OptionBuilder.WithConnectionBacklog(10);

            OptionBuilder.WithDefaultEndpointPort(Convert.ToInt32(this.txtPort.Text));
            OptionBuilder.WithEncryptedEndpointBoundIPAddress(IPAddress.Parse(this.cmbIP.Text));

            MqttServerOptions option = OptionBuilder.Build() as MqttServerOptions;
            //添加验证
            option.ConnectionValidator += context =>
            {
                if (context.Username != "sa")
                {
                    context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                    return;
                }

                if (context.Password != "sa123")
                {
                    context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                    return;
                }

                context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionAccepted;
            };


            mqttServer.ClientConnected += MqttServer_ClientConnected;
            mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;
            mqttServer.ClientSubscribedTopic += MqttServer_ClientSubscribedTopic;
            mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;
            mqttServer.Started += MqttServer_Started;
            mqttServer.Stopped += MqttServer_Stopped;

            mqttServer.StartAsync(option);


        }

        private void MqttServer_Stopped(object sender, EventArgs e)
        {
            MessageBox.Show("服务器已经关闭");
        }

        private void MqttServer_Started(object sender, EventArgs e)
        {
            MessageBox.Show("服务器设备已打开");
        }

        private void MqttServer_ApplicationMessageReceived(object sender, MQTTnet.MqttApplicationMessageReceivedEventArgs e)
        {

            txtMsg.Invoke(new Action(()=>{
                txtMsg.Text+=e.ApplicationMessage.ToString()+"\r\n";
            }));
            // MessageBox.Show($"{e.ApplicationMessage.Topic.ToString()}" );
     
          //  txtMsg.AppendText(e.ApplicationMessage.ToString());
            //throw new NotImplementedException();
        }

        private void MqttServer_ClientSubscribedTopic(object sender, MqttClientSubscribedTopicEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MqttServer_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            //throw new NotImplementedException();

        }

        private void MqttServer_ClientConnected(object sender, MqttClientConnectedEventArgs e)
        {

            // MessageBox.Show($"序号为：{e.ClientId} 的服务器已经连接");
            //throw new NotImplementedException();
        }




        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mqttServer.StopAsync();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Frm_Client frm_Client = new Frm_Client();
            frm_Client.Show();
        }
    }
}
