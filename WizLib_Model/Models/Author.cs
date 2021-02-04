using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLib_Model.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Location { get; set; }

        [NotMapped]
        public string FullName { get 
            {
                return $"{FirstName} {LastName}";
            }
        }

        //this is the current way to do many to many
        //public ICollection<Book> Books { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
