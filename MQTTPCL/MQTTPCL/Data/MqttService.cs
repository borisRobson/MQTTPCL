using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTPCL
{
    public class MqttService : IMqttService
    {
        public bool ConnectClient(MqttClient client)
        {
            client.Connect(Constants.clientID, Constants.user, Constants.passwd);
            bool connected = client.IsConnected;
            return connected;
        }
        public void AssignConnClosedHandler(MqttClient client, MqttClient.ConnectionClosedEventHandler handler)
        {
            client.ConnectionClosed += handler;
        }

        public void AssignMsgPublishedHandler(MqttClient client, MqttClient.MqttMsgPublishedEventHandler handler)
        {
            client.MqttMsgPublished += handler;
        }

        public void AssignPubReceivedHandler(MqttClient client, MqttClient.MqttMsgPublishEventHandler handler)
        {
            client.MqttMsgPublishReceived += handler;            
        }

        public void AssignSubscribedHandler(MqttClient client, MqttClient.MqttMsgSubscribedEventHandler handler)
        {
            client.MqttMsgSubscribed += handler;
        }

        
    }
}
