using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Display Order")]
        [Range(1,int.MaxValue,ErrorMessage ="Display Order for Category must be greater then 0")]
        public int DisplayOrder { get; set; }

    }
}
