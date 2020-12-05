using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Data.Core.Entities.Core.Entities
{
    public class DatabaseServerProperties : AuditEntity<int>
    {
        public string Collation { get; set; }
        public int Size { get; set; }
        public string ServerName { get; set; }
        public string FileName { get; set; }
        public int FileGrowth { get; set; }
    }
}