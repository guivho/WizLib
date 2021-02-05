using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WizLib_Model.Models
{
    public class Fluent_Publisher
    {
        public int PublisherId { get; set; }
        
        public string PublisherName { get; set; }
    
        public string Location { get; set; }

    }
}
