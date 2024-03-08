﻿using System.ComponentModel.DataAnnotations;

namespace MyApp.Models.Requests
{
    public class TypeRequest
    {
        
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
    }
}
