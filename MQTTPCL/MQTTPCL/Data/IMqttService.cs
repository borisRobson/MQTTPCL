using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;


namespace MQTTPCL
{
    public interface IMqttService
    {
        bool ConnectClient(MqttClient client);
        void AssignPubReceivedHandler(MqttClient client, MqttClient.MqttMsgPublishEventHandler  handler);
        void AssignConnClosedHandler(MqttClient client, MqttClient.ConnectionClosedEventHandler handler);
        void AssignSubscribedHandler(MqttClient client, MqttClient.MqttMsgSubscribedEventHandler handler);
        void AssignMsgPublishedHandler(MqttClient client, MqttClient.MqttMsgPublishedEventHandler handler);

    }
}
