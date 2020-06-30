namespace Messaging
{
    /// <summary>
    /// The exchange consumer.
    /// </summary>
    public interface IExchangeConsumer
    {
        /// <summary>
        /// Starts listening a queue.
        /// </summary>
        void Start(string[] routers = null);

        /// <summary>
        /// Stops listening a queue.
        /// </summary>
        void Stop();
    }
}
