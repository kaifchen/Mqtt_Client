using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Mqtt_Client
{
    public partial class Form1 : Form
    {
        string MQTT_ADDRESS = "127.0.0.1";
        int MQTT_PORT = 61613;
        string MQTT_TOPIC = "/home/temperature";//订阅的主题"/home/temperature" 
        private MqttClient client;

        public Form1()
        {
            InitializeComponent();
            //receiveTxtBox.ForeColor = Color.Red;

            /*
             * 必须加入如下语句，否则会出现如下错误信息：
             * System.InvalidOperationException:“线程间操作无效: 从不是创建控件“receiveTxtBox”的线程访问它。”
             */
            CheckForIllegalCrossThreadCalls = false;

            string tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            receiveTxtBox.ForeColor = Color.Red;
            receiveTxtBox.AppendText(tradeTime + " 正在连接服务器……\r\n");
            //创建客户端实例
            client = new MqttClient(MQTT_ADDRESS, MQTT_PORT, false, null, null, MqttSslProtocols.None);

            // 注册消息接收处理事件，还可以注册消息订阅成功、取消订阅成功、与服务器断开等事件处理函数
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            //生成客户端ID并连接服务器
            string clientId = System.Guid.NewGuid().ToString(); //Guid.NewGuid().ToString();
            client.Connect(clientId, "user", "123456");

            // 订阅主题"/home/temperature" 消息质量为 0 
            //client.Subscribe(new string[] { "/home/temperature" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            client.Subscribe(new string[] { MQTT_TOPIC }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });

            tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            if (client.IsConnected)
            {
                receiveTxtBox.SelectionColor = Color.Blue;
                receiveTxtBox.AppendText(tradeTime + " 成功连接服务器。\r\n");
            }
            else
                receiveTxtBox.AppendText(tradeTime + " 连接服务器失败！\r\n");
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            // 发布消息到主题 "/home/temperature" 消息质量为 2,不保留 
            // client.Publish(MQTT_TOPIC, Encoding.UTF8.GetBytes("Hello"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);//发布的是固定消息“Hello”
            client.Publish(MQTT_TOPIC, Encoding.UTF8.GetBytes(sendTxtBox.Text.Trim()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //获取当前时间
            string tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);

            //处理接收到的消息
            string msg = System.Text.Encoding.UTF8.GetString(e.Message);
            //receiveTxtBox.AppendText(tradeTime + " 收到消息：" + msg + "\r\n");//常规处理接收到的消息

            //以下增加了接收到的消息内容颜色不同的功能
            receiveTxtBox.SelectionColor = Color.Red;
            receiveTxtBox.SelectedText = tradeTime+ " 收到消息：";
            receiveTxtBox.SelectionColor = Color.DarkCyan;
            receiveTxtBox.AppendText(msg + "\r\n");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //receiveTxtBox.AppendText("正在退出系统，断开服务器的连接！\r\n");
            client.Disconnect();
        }

        private void subscribeTopicsBtn_Click(object sender, EventArgs e)
        {
            client.Subscribe(new string[] { MQTT_TOPIC }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
        }

        private void cancelSubscribeBtn_Click(object sender, EventArgs e)
        {
            client.Unsubscribe(new string[] { MQTT_TOPIC });
        }
    }
}
