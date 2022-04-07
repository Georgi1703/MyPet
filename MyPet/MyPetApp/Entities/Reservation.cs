using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPetApp.Entities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        [Required]
       
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CountOfProduct { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
