﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WizLib_Model.Models
{
    public class Fluent_Author
    {
        public int AuthorId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Location { get; set; }

        public string FullName { get 
            {
                return $"{FirstName} {LastName}";
            }
        }
        public virtual ICollection<Fluent_BookAuthor> Fluent_BookAuthor { get; set; }

    }
}
