using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace MQTTPCL
{
    public class App : Application
    {
        public static MqttManager mqttManager { get; private set; }
        public MqttClient client;
        public App(MqttClient cli)
        {
            MainPage = new MainView();
  
            client = cli;
            mqttManager = new MqttManager(client);
        }
    }
}
