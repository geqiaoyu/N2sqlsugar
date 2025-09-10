using MQTTnet;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Text;
using System.Threading.Tasks;
using N2.Core.Configuration;
using N2.Core.MqttManager.IService;
using MQTTnet.Client;

namespace N2.Core.MqttManager.Service
{
    public class MqttSubscriber : IMqttSubscriber, IDisposable
    {
        private readonly IManagedMqttClient _mqttClient;
        private readonly ManagedMqttClientOptions _options;
        private bool _isDisposed;
        private Action<string> _messageHandler;

        public MqttSubscriber(MqttConfig config)
        {
            var builder = new MqttClientOptionsBuilder()
                .WithTcpServer(config.BrokerAddress, config.BrokerPort)
                .WithClientId(config.ClientId)
                .WithCredentials(config.Username, config.Password)
                .WithCleanSession();

            _options = new ManagedMqttClientOptionsBuilder()
                .WithClientOptions(builder.Build())
                .Build();

            _mqttClient = new MqttFactory().CreateManagedMqttClient();

            // 注册消息处理事件
            _mqttClient.ApplicationMessageReceivedAsync += OnMessageReceivedAsync;
        }

        private async Task OnMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs e)
        {
            try
            {
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment);
                _messageHandler?.Invoke(payload);
            }
            catch (Exception ex)
            {
                // 可扩展为日志记录
                Console.WriteLine($"消息处理异常: {ex.Message}");
            }
            await Task.CompletedTask.ConfigureAwait(false);
        }

        public async Task Subscribe(string topic, Action<string> messageHandler)
        {
            if (_isDisposed) throw new ObjectDisposedException(nameof(MqttSubscriber));

            _messageHandler = messageHandler;

            await _mqttClient.SubscribeAsync(topic).ConfigureAwait(false);
        }

        public async Task Start()
        {
            if (_isDisposed) throw new ObjectDisposedException(nameof(MqttSubscriber));
            await _mqttClient.StartAsync(_options).ConfigureAwait(false);
        }

        public async Task Stop()
        {
            if (_isDisposed) throw new ObjectDisposedException(nameof(MqttSubscriber));
            await _mqttClient.StopAsync().ConfigureAwait(false);
        }

        public async Task Unsubscribe(string topic)
        {
            if (_isDisposed) throw new ObjectDisposedException(nameof(MqttSubscriber));
            await _mqttClient.UnsubscribeAsync(topic).ConfigureAwait(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) return;

            if (disposing)
            {
                // 移除事件订阅
                _mqttClient.ApplicationMessageReceivedAsync -= OnMessageReceivedAsync;

                try
                {
                    // 使用 Task.Run 避免在 Dispose 中同步等待异步操作
                    Task.Run(async () => await _mqttClient.StopAsync().ConfigureAwait(false)).Wait();
                }
                catch
                {
                    // 忽略停止时的异常
                }

                _mqttClient?.Dispose();
            }

            _isDisposed = true;
        }
    }
}