using System;

namespace MQTTPCL
{
    public interface INotifier
    {
        void Notify(MQTTMessage msg);
    }
}
