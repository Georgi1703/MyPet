using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPetApp.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string NumberItem { get; set; }
        
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Name { get; set; }
       
       
         public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
       
        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]public string Description { get; set; }
        
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
