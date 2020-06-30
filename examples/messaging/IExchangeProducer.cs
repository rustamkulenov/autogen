namespace Messaging
{
    /// <summary>
    /// The exchange producer.
    /// </summary>
    public interface IExchangeProducer
    {
        /// <summary>
        /// Starts connection to a queue.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops connection to a queue.
        /// </summary>
        void Stop();

    }
}
