using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace appCheck.Shared.Model
{
    public class Publication
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string text { get; set; }
        public bool isAllowed { get; set; }


        public int categoryID { get; set; }
        public Category category { get; set; }
    }
}
