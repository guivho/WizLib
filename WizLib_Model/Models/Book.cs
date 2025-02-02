﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLib_Model.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(15)]
        public string ISBN { get; set; }
        [Required]
        public double Price { get; set; }

        //default way to add the relation using the default foreign key BookDetailId
        //while that is the name of the primary index in Categories
        //public BookDetail BookDetail { get; set; }

        //this way does exactly the same, but mentions the extra column
        //explicitely, making it more visible 
        [ForeignKey("BookDetailId")]
        public int? BookDetailId { get; set; }
        public BookDetail BookDetail { get; set; }

        [ForeignKey("PublisherId")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        //this is the current way to do many to many
        //public ICollection<Author> Authors { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
