/**********************************************************************
/* Autogenerated file, all changes will be lost!
***********************************************************************/
using Microsoft.Extensions.Options;
using RabbitMQ.Client.Events;
using Serilog;
using System;
using System.Collections.Generic;
using Messaging.RabbitMQ;

namespace Messaging.Account.Generated {

#region Messages

/// A command to create a new account.
public class CreateAccountCommandMessage : EventArgs
{ 
    /// 
    public Guid PlatformUId { get; set; }

    /// 
    public Guid AccountUId { get; set; }

    /// 
    public bool IsDemo { get; set; }

    /// 
    public string Name { get; set; }

    /// 
    public string Email { get; set; }

    /// 
    public string City { get; set; }

    /// 
    public string State { get; set; }

    /// 
    public string Country { get; set; }

    /// 
    public string ZipCode { get; set; }
}

/// An event to notify consumers an account created.
public class AccountCreatedEventMessage : EventArgs
{ 
    /// 
    public Guid AccountUId { get; set; }

    /// 
    public Guid PlatformUId { get; set; }

    /// 
    public Guid PlatformInstanceUId { get; set; }
}

/// An event to notify consumers that account balance changed.
public class AccountBalanceChangedEventMessage : EventArgs
{ 
    /// 
    public Guid AccountUId { get; set; }

    /// 
    public Guid PlatformUId { get; set; }

    /// 
    public Guid PlatformInstanceUId { get; set; }

    /// 
    public double Amount { get; set; }

    /// 
    public string Currency { get; set; }
}

#endregion

#region Consumers
#region AccountExchangeConsumer

/// <summary>
/// Interface for AccountExchangeListener
/// </summary>
public interface IAccountExchangeConsumer : IExchangeConsumer
{

    event AsyncEventHandler<CreateAccountCommandMessage> OnCreateAccountCommand;
    
    event AsyncEventHandler<AccountCreatedEventMessage> OnAccountCreatedEvent;
    
    event AsyncEventHandler<AccountBalanceChangedEventMessage> OnAccountBalanceChangedEvent;
        
}

public partial class AccountExchangeConsumerSettings : MQListenerSettings
{
    public AccountExchangeConsumerSettings()
    {
        Exchange = "AccountExchange";
    }
}


#endregion // AccountExchangeConsumer 
#endregion

#region Producers
#region AccountExchangeProducer

/// <summary>
/// Interface for AccountExchangeProducer
/// </summary>
public interface IAccountExchangeProducer : IExchangeProducer
{

    /// <summary>
    /// A command to create a new account.
    /// </summary>
    void RaiseCreateAccountCommand(CreateAccountCommandMessage message, string routing);
    
    /// <summary>
    /// An event to notify consumers an account created.
    /// </summary>
    void RaiseAccountCreatedEvent(AccountCreatedEventMessage message, string routing);
    
    /// <summary>
    /// An event to notify consumers that account balance changed.
    /// </summary>
    void RaiseAccountBalanceChangedEvent(AccountBalanceChangedEventMessage message, string routing);
            
}

public class AccountExchangeProducerSettings : MQPublisherSettings
{
    public AccountExchangeProducerSettings()
    {
        Exchange = "AccountExchange";
    }
}

#endregion // AccountExchangeProducer
#endregion

} // namespace