namespace WindowsAppPubs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Titleauthor")]
    public partial class Titleauthor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string au_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string title_id { get; set; }

        public byte? au_ord { get; set; }

        public int? royaltyper { get; set; }

        public virtual Author Author { get; set; }

        public virtual Title Title { get; set; }
    }
}
