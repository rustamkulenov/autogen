namespace Messaging
{
    /// <summary>
    /// Configuration for messaging.
    /// </summary>
    public class MessagingSettings
    {
        /// <summary>
        /// Section name for the configuration.
        /// </summary>
        public const string MESSAGING_CONFIGURATION_SECTION = "MessagingSettings";

        /// <summary>
        /// Environment variable name for RabbitMQ URI.
        /// </summary>
        public const string RABBITMQ_URI_ENV_VAR = "RABBITMQ_URI";

        /// <summary>
        /// URI for connection to RabbitMQ.
        /// <seealso cref="Constants"/>
        /// <seealso cref="https://www.rabbitmq.com/uri-spec.html"/>
        /// </summary>
        public string RabbitMQURI { get; set; }
    }
}