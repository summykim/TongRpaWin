namespace TongRpaCommon.RabbitMq
{
    using RabbitMQ.Client;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using TongRpaCommon.Config;

    public static class RabbitProducer
    {
        private static IConnection connection;
        private static IModel channel;

        public static void Connect()
        {

            ConnectionFactory factory = new ConnectionFactory
            {
                HostName = ConnectionConstants.MqHostName,
                VirtualHost = ConnectionConstants.VirtualHost,
                UserName = ConnectionConstants.UserName,
                Password = ConnectionConstants.Password
            };

            connection = factory.CreateConnection();
            channel = connection.CreateModel();


            channel.QueueDeclare(ConnectionConstants.ServerQueueName, true, false, false, null);
        }

        public static void Disconnect()
        {
            channel = null;

            if (connection.IsOpen)
            {
                connection.Close();
            }

            connection.Dispose();
            connection = null;
        }


        public static void SendMessages(string routingKey, String message )
        {
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: ConnectionConstants.ExchangeName,
                                 routingKey: routingKey,
                                 basicProperties: null,
                                 body: body);

            
        }
        public static void MqSendMessages(String agentId, String message)
        {
            var body = Encoding.UTF8.GetBytes(message);
            string routingKey = "agent."+ agentId + ".result";

            channel.BasicPublish(exchange: ConnectionConstants.ExchangeName,
                                 routingKey: routingKey,
                                 basicProperties: null,
                                 body: body);


        }

    }
}
