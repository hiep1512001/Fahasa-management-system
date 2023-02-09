namespace Fahasa_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETHOADONSPs = new HashSet<CHITIETHOADONSP>();
        }

        [Key]
        public int MASP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENSP { get; set; }

        public int? SOLUONG { get; set; }

        public decimal? GIABAN { get; set; }

        public decimal? GIAMUA { get; set; }

        public int? MANHOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONSP> CHITIETHOADONSPs { get; set; }

        public virtual NHOMSP NHOMSP { get; set; }
        public static string GetNumOfproduct(int productTypeID)
        {
            FahasaContextDB contextDB = new FahasaContextDB();
            List<SANPHAM> products = contextDB.SANPHAMs.ToList();
            /*List<SANPHAM> listProduct = new List<SANPHAM>();*/
            int t = 0;
            foreach (SANPHAM product in products)
            {
                if (product.MANHOM == productTypeID)
                {
                    t = t + 1;
                }
            }
            return t.ToString();
        }
    }
}
