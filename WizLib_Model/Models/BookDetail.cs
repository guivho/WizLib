using System.ComponentModel.DataAnnotations;

namespace WizLib_Model.Models
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }
        
        public Book Book { get; set; }
    }
}
