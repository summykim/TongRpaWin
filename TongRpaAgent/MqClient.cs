using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MqAgent
{
    class MqClient
    {

        public void  send( string message, string routingKey)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "169.56.96.101",
                VirtualHost = "/",
                UserName = "tongrpa",
                Password = "tongrpa1234"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "tong-rpa-queue",
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

 

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "tong-rpa-exchange",
                                     routingKey: routingKey,
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

        }

        public  void Receive(string bindkey)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "169.56.96.101",
                VirtualHost = "/",
                UserName = "tongrpa",
                Password = "tongrpa1234"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                /* channel.QueueDeclare("tong-rpa-queue",
                                      true,
                                      false,
                                      true,
                                      null); */

                channel.ExchangeDeclare("tong-rpa-exchange", "topic", true, true);

                channel.QueueBind("tong-rpa-queue", "tong-rpa-exchange", bindkey);
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);


                    //message 수신
                    Console.WriteLine(" [x] Received {0}", message);

                };
                channel.BasicConsume("tong-rpa-queue",
                                     true,
                                      consumer);

            }
        }
    }
}
