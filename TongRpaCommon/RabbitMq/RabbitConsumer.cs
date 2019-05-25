namespace TongRpaCommon.RabbitMq
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using log4net;
    using RabbitMQ.Client;
    using RabbitMQ.Client.Events;
    using TongRpaCommon.Config;
    using TongRpaCommon.Model;

    public static class  RabbitConsumer
    {
        private static  IConnection connection;
        private static IModel channel;
        [Obsolete]
        private static QueueingBasicConsumer consumer;
        private static readonly ILog logger = LogManager.GetLogger(typeof(RabbitConsumer));
        public static  String AgentStatus="IDLE";
        

        public static void Connect(string agentId)
        {
            string bindKey = ConnectionConstants.BindPrefix+ agentId + ConnectionConstants.Bindsufix;


            ConnectionFactory factory = new ConnectionFactory
            {
                HostName = ConnectionConstants.MqHostName,
                VirtualHost = ConnectionConstants.VirtualHost,
                UserName = ConnectionConstants.UserName,
                Password = ConnectionConstants.Password
            }; 
            
            connection = factory.CreateConnection();
            channel = connection.CreateModel();
            channel.ExchangeDeclare(ConnectionConstants.ExchangeName, "topic", true, true, null);

            IDictionary<string, object> args = new Dictionary<string, object>();
            args.Add("x-expires", 3600000);


            channel.QueueDeclare(ConnectionConstants.AgentQueueName+"-"+ agentId, true, false, false, args);
            channel.QueueBind(ConnectionConstants.AgentQueueName + "-" + agentId, ConnectionConstants.ExchangeName, bindKey);


        }
        public static void DisConnect()
        {
   
            connection.Abort();
            connection.Close();
            connection.Dispose();
            
        }

        [Obsolete]
        public static void ConsumeMessagesStart(string agentId)
        {


             consumer = new QueueingBasicConsumer(channel);

            // turn auto acknowledge off so we can do it manually. This is so we don't remove items from the queue until we're perfectly happy
            const bool autoAck = false;
            channel.BasicConsume(ConnectionConstants.AgentQueueName + "-" + agentId , autoAck, consumer);

        }

        [Obsolete]
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

                channel.BasicAck(ea.DeliveryTag, false);

            }
            return message;


        }

        [Obsolete]
        public static MqRecvVo  getRevcMessages()
        {
            BasicDeliverEventArgs ea = null;
            try
            {
                ea = consumer.Queue.Dequeue();
            }
            catch (EndOfStreamException endOfStreamException)
            {
                logger.Error(endOfStreamException);

            }

            MqRecvVo mrVo = null;
            if (ea != null)
            {
                byte[] body = ea.Body;
                string message = System.Text.Encoding.UTF8.GetString(body);
                logger.Debug(message);
                 mrVo = new MqRecvVo(message);

                if (mrVo.req_typ == "HLTH")//에이전트 상태 확인
                {
                    channel.BasicAck(ea.DeliveryTag, false);
                }
                else //Job 실행요청 
                {
                    logger.Debug("getRevcMessages AgentStatus ==>  " + AgentStatus);
                   if(AgentStatus!="IDLE") //실행가능
                    {
                        if (mrVo.req_typ == "PY")//파이썬 실행
                        {
                            channel.BasicAck(ea.DeliveryTag, false);

                        }
                        else if (mrVo.req_typ == "RST")//REST 실행
                        {
                            channel.BasicAck(ea.DeliveryTag, false);
                        }
                    }
                    else// 나중에 다시 처리
                    {
                        channel.BasicAck(ea.DeliveryTag, true );
                    }

                }

                

            }
            return mrVo;


        }
    }
}