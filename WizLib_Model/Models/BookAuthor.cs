using System;
using System.Collections.Generic;
using System.Text;

namespace WizLib_Model.Models
{
    //no longer needed to create explicit intesection table
    public class BookAuthor
    {
        public int BookId { get; set; }

        public int AuthorId { get; set; }

        public Book Book { get; set; }
        
        public Author Author { get; set; }
    }
}
