using System;
using System.Collections.Generic;
using System.Text;

namespace WizLib_Model.Models
{
    public class Fluent_BookAuthor
    {
        public int BookId { get; set; }

        public int AuthorId { get; set; }

        public Fluent_Author Fluent_Author { get; set; }
        public Fluent_Book Fluent_Book { get; set; }

    }
}
