﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EducationSystem.Dtos.Account
{
    public class RemoveLoginDTO
    {
        [Required]
        [Display(Name = "Login provider")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Provider key")]
        public string ProviderKey { get; set; }
    }
}