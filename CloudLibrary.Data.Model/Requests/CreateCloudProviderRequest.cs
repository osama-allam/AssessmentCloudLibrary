﻿using System.ComponentModel.DataAnnotations;

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