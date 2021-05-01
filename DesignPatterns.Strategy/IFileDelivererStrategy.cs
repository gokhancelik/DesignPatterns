namespace DesignPatterns.Strategy
{
    public interface IFileDelivererStrategy
    {
        string Destination { get; }

        string Deliver(byte[] contents);
    }
}