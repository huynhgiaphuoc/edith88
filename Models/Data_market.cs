namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_market
    {
        [Key]
        public int ID_data_tour { get; set; }

        public int? ID_service { get; set; }

        public int? ID_order { get; set; }

        public virtual Order Order { get; set; }

        public virtual Service Service { get; set; }
    }
}
