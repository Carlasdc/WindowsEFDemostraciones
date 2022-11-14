namespace WindowsAppPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Discount
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string discounttype { get; set; }

        [StringLength(4)]
        public string stor_id { get; set; }

        public short? lowqty { get; set; }

        public short? highqty { get; set; }

        [Key]
        [Column("Discount", Order = 1)]
        public decimal Discount1 { get; set; }

        public virtual Store Store { get; set; }
    }
}
