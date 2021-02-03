﻿using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class Category
    {
        // [Key]  superfluous if field name is Id
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
