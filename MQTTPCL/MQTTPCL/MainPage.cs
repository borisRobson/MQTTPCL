using System;
using System.Diagnostics;
using Xamarin.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace MQTTPCL
{
    
    public class MainPage 
    {
        public static MqttManager mqttManager { get; private set; }
        public MqttClient client;
        public MainPage(MqttClient cli)
        {
            client = cli;
            mqttManager = new MqttManager( client);
        }
        
    }
    
}
