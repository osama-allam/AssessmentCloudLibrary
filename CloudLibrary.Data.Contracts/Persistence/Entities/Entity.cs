using Newtonsoft.Json;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class Entity<T> where T : struct
    {
        public virtual T Id { get; set; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}