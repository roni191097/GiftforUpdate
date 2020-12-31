using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GiftforUpdate.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input a Category name")]
        [StringLength(30, ErrorMessage = "You cannot have a name longer than 30 characters")]
        public String Name { get; set; }
        [Required]
        public int Type { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public String ImageUrl { get; set; }
    }
}
