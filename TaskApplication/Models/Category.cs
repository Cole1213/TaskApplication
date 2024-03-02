﻿using System.ComponentModel.DataAnnotations;

namespace TaskApplication.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
    }
}
