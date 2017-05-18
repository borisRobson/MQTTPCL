using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Diagnostics;
using Xamarin.Forms;

namespace MQTTPCL
{
    public class MqttManager
    {
        
        MqttClient client;
        public MqttManager(MqttClient cli)
        {
            client = cli;
        }

        public bool ConnectClient()
        {
            client.Connect(Constants.clientID, Constants.user, Constants.passwd);
            bool connected = client.IsConnected;
            return connected;
        }

        public void Subscribe(string[] topics, byte[] qos)
        {
            client.MqttMsgSubscribed += Client_MqttMsgSubscribed;
            client.Subscribe(topics, qos);
        }

        private void Client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            Debug.WriteLine("***SUBCRIBED***");
            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Debug.WriteLine("****MSG RECEIEVED****");
            Debug.WriteLine(Encoding.UTF8.GetString(e.Message, 0, e.Message.Length));
            MQTTMessage msg = new MQTTMessage();
            msg.Payload = Encoding.UTF8.GetString(e.Message, 0, e.Message.Length);
            msg.Topic = e.Topic;
            msg.Qos = e.QosLevel;

            DependencyService.Get<INotifier>().Notify(msg);
        }
    }
}
