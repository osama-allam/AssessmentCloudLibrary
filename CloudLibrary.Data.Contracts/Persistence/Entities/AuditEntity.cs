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
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime DateModified { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual string ModifiedBy { get; set; }

    }
}