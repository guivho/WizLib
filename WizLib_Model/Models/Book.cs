using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLib_Model.Models
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(15)]
        public string  ISBN { get; set; }
        [Required]
        public double Price { get; set; }

        //default way to add the relation using the default foreign key CategoryId
        //while that is the name of the primary index in Categories
        //public Category Category { get; set; }

        //this way does exactly the same, but mentions the extra column
        //explicitely, making it more visible 
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
