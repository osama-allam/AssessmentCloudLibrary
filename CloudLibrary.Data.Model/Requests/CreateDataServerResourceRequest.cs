using CloudLibrary.Data.Common.Persistence.Enum;
using Newtonsoft.Json;

namespace CloudLibrary.Core.Services.Requests
{
    public class CreateDataServerResourceRequest : CreateResourceRequest
    {
        public DbType DbType { get; set; }
        public string Version { get; set; }
    }
}