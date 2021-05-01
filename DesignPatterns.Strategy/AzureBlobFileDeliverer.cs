using System;

namespace DesignPatterns.Strategy
{
    public class AzureBlobFileDeliverer : IFileDelivererStrategy
    {
        public AzureBlobFileDeliverer()
        {
        }
        public string Destination => "azure-blob";
        public string Deliver(byte[] contents)
        {
            return "Delivered to azure blob";
        }
    }
}