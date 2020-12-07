using System;
using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class AuditEntity<T> : Entity<T>, IAuditEntity<T> where T : class
    {
        public AuditEntity()
        {
            CreatedBy = ModifiedBy = "System";
            DateCreated = DateModified = DateTime.Now;
        }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}