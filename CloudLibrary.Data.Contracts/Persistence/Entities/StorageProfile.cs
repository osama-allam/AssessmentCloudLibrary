namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class StorageProfile : AuditEntity<string>
    {
        public string DiskInfo { get; set; }
    }
}