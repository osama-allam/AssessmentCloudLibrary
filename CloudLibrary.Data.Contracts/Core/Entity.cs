using Newtonsoft.Json;

namespace CloudLibrary.Data.Common.Core
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