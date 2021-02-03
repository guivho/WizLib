using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class Genre
    {
        //[Key] superfluous if field name ends on Id
        public int GenreId { get; set; }
        [Required]
        public string GenreName { get; set; }
        [Range(1, int.MaxValue, ErrorMessage ="Range must be greater than 0.")]
        public int DisplayOrder { get; set; }
    }
}
