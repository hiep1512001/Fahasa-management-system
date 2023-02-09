namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHAMCONG")]
    public partial class CHAMCONG
    {
        [Key]
        public int MACC { get; set; }

        public int? MANV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYLAM { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
