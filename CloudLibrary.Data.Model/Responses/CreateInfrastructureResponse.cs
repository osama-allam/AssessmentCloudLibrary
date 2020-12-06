using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Responses
{
    public class CreateInfrastructureResponse : ResponseData
    {
        public Infrastructure Infrastructure { get; set; }
    }
}