using System;

namespace MQTTPCL
{
    public class MQTTMessage
    {
        public string Topic { get; set; }
        public ushort ID { get; set; }
        public string Payload { get; set; }
        public byte Qos { get; set; }
    }
}
