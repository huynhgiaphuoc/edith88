namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tour_Outside
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour_Outside()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int ID_tour_outside { get; set; }

        [Required]
        [StringLength(8)]
        public string Tour_Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Image { get; set; }

        [Required]
        [StringLength(1500)]
        public string Place { get; set; }

        [Required]
        [StringLength(1500)]
        public string Description { get; set; }

        [Required]
        [StringLength(1550)]
        public string Note { get; set; }

        [Required]
        [StringLength(1000)]
        public string Visa_support { get; set; }

        [Required]
        [StringLength(100)]
        public string Country_code { get; set; }

        public int? ID_tour { get; set; }

        public int? ID_schedule { get; set; }

        public virtual Schedule Schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
