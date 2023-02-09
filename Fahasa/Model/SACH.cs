namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIETHOADONSACHes = new HashSet<CHITIETHOADONSACH>();
        }

        [Key]
        public int MASACH { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSACH { get; set; }

        public decimal GIAMUA { get; set; }

        public decimal GIABAN { get; set; }

        public int SOLUONG { get; set; }

        public int? MANXB { get; set; }

        public int? MATL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONSACH> CHITIETHOADONSACHes { get; set; }

        public virtual NXB NXB { get; set; }

        public virtual THELOAI THELOAI { get; set; }
        public static string GetNumOfBooks()
        {
            int numOfBooks = 0;
            FahasaContextDB contextDB = new FahasaContextDB();
            numOfBooks = contextDB.SACHes.Count();
            return numOfBooks.ToString();
        }
    }
}
