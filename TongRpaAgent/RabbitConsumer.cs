namespace MqAgent
{
    using System;
    using System.IO;
    using RabbitMQ.Client;
    using RabbitMQ.Client.Events;

    internal static class  RabbitConsumer
    {
        private static  IConnection connection;
        private static IModel channel;
        private static QueueingBasicConsumer consumer;

        public static void Connect(string bindkey)
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
            channel.ExchangeDeclare(ConnectionConstants.ExchangeName, "topic", true, true, null);
            channel.QueueDeclare(ConnectionConstants.QueueName, true, false, false, null);
             channel.QueueBind(ConnectionConstants.QueueName, ConnectionConstants.ExchangeName, bindkey);


        }

        public static void ConsumeMessagesStart()
        {


             consumer = new QueueingBasicConsumer(channel);

            // turn auto acknowledge off so we can do it manually. This is so we don't remove items from the queue until we're perfectly happy
            const bool autoAck = true;
            channel.BasicConsume(ConnectionConstants.QueueName, autoAck, consumer);

        }
        public static String getMessages()
        {
           BasicDeliverEventArgs ea = null;
            try
            {
                ea = consumer.Queue.Dequeue();
            }
            catch (EndOfStreamException endOfStreamException)
            {
                System.Console.WriteLine(endOfStreamException);

            }
            
            string message = "";
            if (ea != null)
            {
                byte[] body = ea.Body;
                 message = System.Text.Encoding.UTF8.GetString(body);

                // Acknowledge message received and processed
                System.Console.WriteLine(" Processed ", message);

            }
            return message;


        }
    }
}