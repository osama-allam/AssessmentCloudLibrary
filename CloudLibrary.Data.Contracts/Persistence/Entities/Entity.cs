using CloudLibrary.Data.Common.Contracts.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class Entity<T>
    {
        [JsonIgnore]
        public T Id { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            } );
        }
    }

}