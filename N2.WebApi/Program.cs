using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using N2.Core.Configuration;
using N2.Core.MqttManager.IService;
using N2.WebApi.Controllers.MqDataHandle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();

            #region kafka������Ϣ
            //if (AppSetting.Kafka.UseConsumer)
            //{
            //    using var scope = host.Services.CreateScope();
            //    var testConsumer = scope.ServiceProvider.GetService<IKafkaConsumer<string, string>>();
            //    testConsumer.Consume(res =>
            //    {
            //        Console.WriteLine($"recieve:{DateTime.Now.ToLongTimeString()}  value:{res.Message.Value}");
            //        //��̬���� ���ݴ��� ���Ȳ���
            //        bool bl = DataHandle.AlarmData(res.Message.Value);
            //        //�ص������践�ر���ִ��Commit
            //        return bl;
            //    }, AppSetting.Kafka.Topics.TestTopic);
            //}
            #endregion
            #region MQTT������Ϣ
            if (AppSetting.Mqtt.UseSubscriber)
            {
                using var scope = host.Services.CreateScope();
                var mqttSubscriber = scope.ServiceProvider.GetService<IMqttSubscriber>();

                mqttSubscriber.Start().Wait();
                //mqttSubscriber.Subscribe(AppSetting.Mqtt.Topics.AlarmTopics, message =>
                //{
                //    // ������յ�����Ϣ
                //    DataHandle.AlarmData(message);
                //}).Wait();
                foreach (var topic in AppSetting.Mqtt.Topics.AlarmTopics)
                {
                    mqttSubscriber.Subscribe(topic, message =>
                    {
                        // ������յ�����Ϣ
                        DataHandle.AlarmData(message);
                    }).Wait();
                }
            }
            #endregion
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.ConfigureKestrel(serverOptions =>
                       {
                           serverOptions.Limits.MaxRequestBodySize = 10485760;
                           // Set properties and call methods on options
                       });
                       webBuilder.UseKestrel().UseUrls("http://*:9991");
                       webBuilder.UseIIS();
                       webBuilder.UseStartup<Startup>();
                   }).UseServiceProviderFactory(new AutofacServiceProviderFactory());
    }
}
