using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcSample.Models
{
    public class CategoriesViewModel
    {
        [ScaffoldColumn(false)]
        [DisplayName("ID")]
        public int CategoryID { get; set; }

        [DisplayName("Category")]
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}