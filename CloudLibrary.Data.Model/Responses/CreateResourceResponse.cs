using CloudLibrary.Data.Common.Contracts.Entities;

namespace CloudLibrary.Core.Services.Responses
{
    public class CreateResourceResponse<TResource> : ResponseData where TResource : IResource<string>
    {
        public TResource Resource { get; set; }
    }
}