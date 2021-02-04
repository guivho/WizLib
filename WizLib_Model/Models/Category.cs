using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
