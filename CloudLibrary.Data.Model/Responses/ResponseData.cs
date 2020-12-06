using System.Reflection;
using CloudLibrary.Data.Common.Contracts.Entities;
using Newtonsoft.Json;

namespace CloudLibrary.Core.Services.Responses
{
    public class ResponseData
    {
        public OperationStatus OperationStatus { get; set; }
        public string Description { get; set; }
    }
}