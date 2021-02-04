using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WizLib_Model.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required]
        [Column("Name")]
        public string GenreName { get; set; }
        //[Range(1, int.MaxValue, ErrorMessage ="Range must be greater than 0.")]
        //public int DisplayOrder { get; set; }
    }
}
