using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using WizLib_Model.Models;

namespace WizLib_Model.ViewModel
{
    public class BookVM
    {
        public Book Book { get; set; }

        public IEnumerable<SelectListItem> PublisherList { get; set; }
    }
}
