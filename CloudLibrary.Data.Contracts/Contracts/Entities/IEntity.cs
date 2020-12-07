using Newtonsoft.Json;

namespace CloudLibrary.Data.Common.Contracts.Entities
{
    public interface IEntity<T> where T : class
    {
        [JsonIgnore]
        T Id { get; set; }
        string ToJson();
    }
}