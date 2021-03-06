using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKenaBecha.Models
{
    public class TagNames
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string TagType { get; set; }
    }
}
