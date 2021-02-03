using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WizLib_Model.Models
{
    public class Category
    {
        [Key] // superfluous if fied name is Id
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
