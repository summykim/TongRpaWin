namespace MqAgent
{
    using System;
    using System.Text;
    using System.Threading;

    using RabbitMQ.Client;

    internal static class RabbitProducer
    {
        private static IConnection connection;
        private static IModel channel;

        public static void Connect()
        {

            ConnectionFactory factory = new ConnectionFactory
            {
                HostName = ConnectionConstants.HostName,
                VirtualHost = ConnectionConstants.VirtualHost,
                UserName = ConnectionConstants.UserName,
                Password = ConnectionConstants.Password
            };

            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.QueueDeclare(ConnectionConstants.QueueName, true, false, false, null);
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

        private const int MessageCount = 10;

        public static void SendMessages(string routingKey, String message )
        {
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: ConnectionConstants.ExchangeName,
                                 routingKey: routingKey,
                                 basicProperties: null,
                                 body: body);

            
        }

    }
}
