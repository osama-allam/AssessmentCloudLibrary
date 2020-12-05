namespace CloudLibrary.Data.Common.Contracts.Entities
{
    public interface IEntity<T> where T : class
    {
        T Id { get; set; }
        string ToJson();
    }
}