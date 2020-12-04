namespace CloudLibrary.Data.Common.Core
{
    public class NetworkProfile : AuditEntity<int>
    {
        public string PrivateIp { get; set; }
        public string PublicIp { get; set; }
        public string Dns { get; set; }
    }
}