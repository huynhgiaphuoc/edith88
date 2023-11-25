namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column("location")]
        [StringLength(255)]
        public string location1 { get; set; }

        [StringLength(255)]
        public string at { get; set; }

        [StringLength(255)]
        public string img { get; set; }
    }
}
