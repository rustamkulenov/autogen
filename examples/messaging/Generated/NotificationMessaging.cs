/**********************************************************************
/* Autogenerated file, all changes will be lost!
***********************************************************************/
using Microsoft.Extensions.Options;
using RabbitMQ.Client.Events;
using Serilog;
using System;
using System.Collections.Generic;
using Messaging.RabbitMQ;

namespace Messaging.Notification.Generated {

#region Messages

/// A command to send an email.
public class SendEmailCommandMessage : EventArgs
{ 
    /// 
    public Guid UId { get; set; }

    /// 
    public string[] SendTo { get; set; }

    /// 
    public string TemplateName { get; set; }

    /// 
    public object Parameters { get; set; }
}

#endregion

#region Consumers
#region NotificationExchangeConsumer

/// <summary>
/// Interface for NotificationExchangeListener
/// </summary>
public interface INotificationExchangeConsumer : IExchangeConsumer
{

    event AsyncEventHandler<SendEmailCommandMessage> OnSendEmailCommand;
        
}

public partial class NotificationExchangeConsumerSettings : MQListenerSettings
{
    public NotificationExchangeConsumerSettings()
    {
        Exchange = "NotificationExchange";
    }
}


#endregion // NotificationExchangeConsumer 
#endregion

#region Producers
#region NotificationExchangeProducer

/// <summary>
/// Interface for NotificationExchangeProducer
/// </summary>
public interface INotificationExchangeProducer : IExchangeProducer
{

    /// <summary>
    /// A command to send an email.
    /// </summary>
    void RaiseSendEmailCommand(SendEmailCommandMessage message, string routing);
            
}

public class NotificationExchangeProducerSettings : MQPublisherSettings
{
    public NotificationExchangeProducerSettings()
    {
        Exchange = "NotificationExchange";
    }
}

#endregion // NotificationExchangeProducer
#endregion

} // namespace