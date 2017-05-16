using System;
using System.Diagnostics;
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
            client = cli;
            mqttManager = new MqttManager(new MqttService(), client);
            
            MainPage = new NavigationPage(new MainView());

            
           
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

}
