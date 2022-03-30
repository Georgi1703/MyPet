using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPetApp.Entities
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
        public virtual ICollection<Product> Products { get; set; }
    }
}
