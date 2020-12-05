namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class StorageProfile : AuditEntity<int>
    {
        public string DiskInfo { get; set; }
    }
}