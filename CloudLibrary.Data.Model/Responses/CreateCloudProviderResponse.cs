using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Responses
{
    public class CreateCloudProviderResponse : ResponseData
    {
        public CloudProvider CloudProvider { get; set; }
    }
}