using System;
using CloudLibrary.Data.Common.Contracts;

namespace CloudLibrary.Data.Common.Core
{
    public class AuditEntity<T> : Entity<T>, IAuditEntity where T : struct
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