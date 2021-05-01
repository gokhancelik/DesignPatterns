namespace DesignPatterns.Web.Models
{
    public class FileDeliverRequest
    {
        public byte[] Content { get; set; }
        public string Destination { get; set; }
    }
}