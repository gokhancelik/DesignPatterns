using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class FileDelivererService : IFileDelivererService
    {
        private readonly IEnumerable<IFileDelivererStrategy> _strategies;

        public FileDelivererService(IEnumerable<IFileDelivererStrategy> strategies)
        {
            _strategies = strategies;
        }
        public string Deliver(byte[] contents, string destination)
        {
            var deliverer = _strategies.FirstOrDefault(p => p.Destination == destination);
            if (deliverer != null)
            {
                return deliverer.Deliver(contents);
            }
            else
            {
                throw new ArgumentException($"{nameof(destination)} is not valid");
            }
        }
    }
}
