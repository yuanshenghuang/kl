using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListFor.Models
{
    public class Category
    {
        [DisplayName("Select a category")]
        public string SelectedCategory { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }

    }
}