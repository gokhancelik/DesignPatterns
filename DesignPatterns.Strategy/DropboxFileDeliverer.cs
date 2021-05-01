using System;

namespace DesignPatterns.Strategy
{
    public class DropboxFileDeliverer : IFileDelivererStrategy
    {
        public DropboxFileDeliverer()
        {
        }

        public string Destination => "dropbox";

        public string Deliver(byte[] contents)
        {
            return "Delivered to dropbox";
        }
    }
}