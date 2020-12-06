namespace CloudLibrary.Data.Common.Contracts.Entities
{
    public interface IDirectoryEntity<T> : IAuditEntity<T> where T : class
    {
        string Name { get; set; }
        string Location { get; set; }
        string Address { get; set; }
    }
}