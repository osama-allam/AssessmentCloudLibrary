namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class HardwareProfile : AuditEntity<int>
    {
        public int MemorySize { get; set; }
    }
}