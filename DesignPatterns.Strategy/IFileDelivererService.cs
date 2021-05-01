namespace DesignPatterns.Strategy
{
    public interface IFileDelivererService
    {
        string Deliver(byte[] contents, string destination);
    }
}