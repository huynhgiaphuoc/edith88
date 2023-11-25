namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Tour_Outside = new HashSet<Tour_Outside>();
            Tour_Inside = new HashSet<Tour_Inside>();
        }

        [Key]
        public int ID_schedule { get; set; }

        [Required]
        [StringLength(20)]
        public string Start_time { get; set; }

        [Required]
        [StringLength(20)]
        public string Day_begin { get; set; }

        [Required]
        [StringLength(20)]
        public string End_time { get; set; }

        [Required]
        [StringLength(20)]
        public string End_Day { get; set; }

        [StringLength(1500)]
        public string Activities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Outside> Tour_Outside { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour_Inside> Tour_Inside { get; set; }
    }
}
