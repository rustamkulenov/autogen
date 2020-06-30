namespace Messaging.RabbitMQ
{
    /// <summary>
    /// MQ publisher settings.
    /// </summary>
    /// <seealso cref="Hi5.Messaging.MessagingSettings" />
    public class MQPublisherSettings : MessagingSettings
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
    }
}