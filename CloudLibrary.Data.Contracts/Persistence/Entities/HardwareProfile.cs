namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class HardwareProfile : AuditEntity<string>
    {
        public int MemorySize { get; set; }
    }
}