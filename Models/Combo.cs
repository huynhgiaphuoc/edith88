namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Combo")]
    public partial class Combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Combo()
        {
            Ticket_Combo = new HashSet<Ticket_Combo>();
        }

        [Key]
        public int ID_combo { get; set; }

        [Required]
        [StringLength(8)]
        public string Combo_code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? ID_restaurant { get; set; }

        public int? ID_hotel { get; set; }

        public int? ID_airline { get; set; }

        public int? ID_tour { get; set; }

        public int? ID_service { get; set; }

        public virtual Airline Airline { get; set; }

        public virtual Service Service { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual Tour Tour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket_Combo> Ticket_Combo { get; set; }
    }
}
