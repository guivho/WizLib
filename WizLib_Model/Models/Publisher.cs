using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WizLib_Model.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        
        [Required]
        public string PublisherName { get; set; }
    
        [Required]
        public string Location { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
