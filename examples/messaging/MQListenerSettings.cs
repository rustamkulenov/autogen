namespace Messaging
{
    /// <summary>
    /// The MQ listener settings.
    /// </summary>
    public class MQListenerSettings : MessagingSettings
    {
        /// <summary>
        /// Gets or sets the listener exchange name.
        /// </summary>
        public string Exchange { get; set; }
        /// <summary>
        /// Gets or sets the type of the listener exchange type.
        /// </summary>
        public string ExchangeType { get; set; } = global::RabbitMQ.Client.ExchangeType.Topic;
        /// <summary>
        /// Gets or sets a value indicating whether the listener exchange should be durable.
        /// </summary>
        public bool ExchangeDurable { get; set; } = true;
        /// <summary>
        /// Gets or sets a value indicating whether the listener exchange should be automatic deleted.
        /// </summary>
        public bool ExchangeAutoDelete { get; set; } = false;
        /// <summary>
        /// Gets or sets the listener queue name.
        /// </summary>
        public string Queue { get; set; } = "";
        /// <summary>
        /// Gets or sets a value indicating whether the listener queue should be durable.
        /// </summary>
        public bool QueueDurable { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether the listener queue should be exclusive.
        /// </summary>
        public bool QueueExclusive { get; set; } = true;
        /// <summary>
        /// Gets or sets a value indicating whether the listener queue should be automatic deleted.
        /// </summary>
        public bool QueueAutoDelete { get; set; } = true;
    }
}