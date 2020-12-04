using System;

namespace CloudLibrary.Data.Common.Contracts
{
    public interface IAuditEntity
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
    }
}