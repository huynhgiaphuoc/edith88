namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Airline")]
    public partial class Airline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airline()
        {
            Comboes = new HashSet<Combo>();
        }

        [Key]
        public int ID_airline { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(8)]
        public string Air_Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Place_go { get; set; }

        [Required]
        [StringLength(100)]
        public string Place_leave { get; set; }

        [Required]
        [StringLength(100)]
        public string Time_go { get; set; }

        [Required]
        [StringLength(100)]
        public string Time_leave { get; set; }

        [Required]
        [StringLength(100)]
        public string Day_go { get; set; }

        [Required]
        [StringLength(100)]
        public string Day_leave { get; set; }

        [Required]
        [StringLength(255)]
        public string Note { get; set; }

        [Required]
        [StringLength(100)]
        public string Ticket { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        public string Note_ticket { get; set; }

        public int? ID_service { get; set; }

        public virtual Service Service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Combo> Comboes { get; set; }
    }
}
