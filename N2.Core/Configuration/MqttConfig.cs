using System;
using System.Collections.Generic;

namespace N2.Core.Configuration
{
    public class MqttConfig
    {
        public string BrokerAddress { get; set; }
        public int BrokerPort { get; set; }
        public string ClientId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UseSubscriber { get; set; }
        public MqttTopics Topics { get; set; }

        public class MqttTopics
        {
            public List<string> AlarmTopics { get; set; }
        }
    }
}