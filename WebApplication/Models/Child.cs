﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Child
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}