namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [Key]
        public int ID_room { get; set; }

        [Required]
        [StringLength(100)]
        public string Room_code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Numberof_room { get; set; }

        [Required]
        [StringLength(100)]
        public string Evaluate { get; set; }

        [Required]
        [StringLength(100)]
        public string Image { get; set; }

        [Required]
        [StringLength(1255)]
        public string Note { get; set; }

        public int? ID_hotel { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}
