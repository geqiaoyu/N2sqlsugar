using System;
using System.Threading.Tasks;

namespace N2.Core.MqttManager.IService
{
    public interface IMqttSubscriber : IDisposable
    {
        Task Subscribe(string topic, Action<string> messageHandler);
        Task Unsubscribe(string topic);
        Task Start();
        Task Stop();
    }
}