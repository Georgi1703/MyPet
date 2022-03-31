using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPetApp.Entities
{
    public class Product
    {
        public Product()
        {
             this.Reservations = new HashSet<Reservation>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string NumberItem { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
       
       
         public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
