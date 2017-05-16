using System;

namespace MQTTPCL
{
    public class MQTTMessage
    {
        public string Topic { get; set; }
        public ushort ID { get; set; }
        public string Payload { get; set; }
        public string Qos { get; set; }
    }
}
