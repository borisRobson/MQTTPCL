using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MQTTPCL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }
        void OnConnectClicked(object sender, EventArgs e)
        {            
           
           bool connected = App.mqttManager.ConnectClient();

            if (connected)
           {
               Debug.WriteLine("****CONNECTED*****");
                string[] topics = new string[1];
                topics[0] = "/test";
                byte[] qos = new byte[1];
                qos[0] = (byte)1;
                App.mqttManager.Subscribe(topics, qos);
                
           }
           else
           {
               Debug.WriteLine("****NOT CONNECTED*****");
           }

            
           
        }
    }
}