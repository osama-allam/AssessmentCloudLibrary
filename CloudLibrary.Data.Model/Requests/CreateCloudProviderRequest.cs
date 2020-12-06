using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CloudLibrary.Core.Services.Requests
{
    public class CreateCloudProviderRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
    }
}