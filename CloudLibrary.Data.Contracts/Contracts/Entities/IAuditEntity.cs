using System;

namespace CloudLibrary.Data.Common.Contracts.Entities
{
    public interface IAuditEntity<T> : IEntity<T> where T : class
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }
}