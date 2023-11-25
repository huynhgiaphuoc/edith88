namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orderdetail
    {
        [Key]
        public int ID_orderdetails { get; set; }

        [Required]
        [StringLength(100)]
        public string Name_ticket { get; set; }

        [Required]
        [StringLength(100)]
        public string Payment_method { get; set; }

        [Required]
        [StringLength(100)]
        public string Numberof_ticket { get; set; }

        [Column(TypeName = "money")]
        public decimal Total_price { get; set; }

        public int? ID_order { get; set; }

        public virtual Order Order { get; set; }
    }
}
