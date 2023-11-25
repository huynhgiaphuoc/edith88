namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ticket_Combo
    {
        [Key]
        public int ID_ticket { get; set; }

        [Required]
        [StringLength(100)]
        public string Ticket_combo_code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Numberof_ticket { get; set; }

        public int Ticket_leave { get; set; }

        public int Remaining_ticket { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string Note { get; set; }

        public int? ID_combo { get; set; }

        public virtual Combo Combo { get; set; }
    }
}
