using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTPCL
{
    public static class Constants
    {
        public static string brokerAddr = "m20.cloudmqtt.com";
        public static int brokerPort = 18022;
        public static string clientID = Guid.NewGuid().ToString();
        public static string user = "ihygepmh";
        public static string passwd = "GAB35__1D1zg";
    }
}
