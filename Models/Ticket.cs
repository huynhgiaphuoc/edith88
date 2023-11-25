namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        [Key]
        public int ID_ticket { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Ticket_code { get; set; }

        public int Numberof_ticket { get; set; }

        public int Ticket_leave { get; set; }

        public int Remaining_ticket { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(1500)]
        public string Note { get; set; }

        public int? ID_tour_outside { get; set; }

        public int? ID_tour_inside { get; set; }

        public virtual Tour_Inside Tour_Inside { get; set; }

        public virtual Tour_Outside Tour_Outside { get; set; }
    }
}
