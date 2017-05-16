using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTPCL
{
    public class MqttManager
    {
        IMqttService mqttService;
        MqttClient client;
        public MqttManager(IMqttService service, MqttClient cli)
        {
            mqttService = service;
            client = cli;
        }
        public bool ConnectClient()
        {            
            return mqttService.ConnectClient(client);
        }
        public void AssignPubReceivedHandler(MqttClient client, MqttClient.MqttMsgPublishEventHandler handler)
        {
            mqttService.AssignPubReceivedHandler(client, handler);
        }
        public void AssignConnClosedHandler(MqttClient client, MqttClient.ConnectionClosedEventHandler handler)
        {
            mqttService.AssignConnClosedHandler(client, handler);
        }
        public void AssignSubscribedHandler(MqttClient client, MqttClient.MqttMsgSubscribedEventHandler handler)
        {
            mqttService.AssignSubscribedHandler(client, handler);
        }
        public void AssignMsgPublishedHandler(MqttClient client, MqttClient.MqttMsgPublishedEventHandler handler)
        {
            mqttService.AssignMsgPublishedHandler(client, handler);
        }
    }
}
