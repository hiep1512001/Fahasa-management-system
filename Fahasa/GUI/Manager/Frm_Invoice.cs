using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahasa_Management_System.Model;
using Fahasa_Management_System;

namespace Fahasa_Management_System.GUI.Manager
{
    public partial class Frm_Invoice : Form
    {
        static public List<Hoadon> listDHchitiet;
        static public List<Doanthungay> listDoanhthu;
        private int Sohd = 0;
        private DataTable dtInvoice;
        public Frm_Invoice()
        {
            InitializeComponent();
        }

        private void Frm_Invoice_Load(object sender, EventArgs e)
        {
            dtInvoice = new DataTable("dtinvoice");
            dtInvoice.Columns.Add("Mã hóa đơn", System.Type.GetType("System.Int32"));
            dtInvoice.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            dtInvoice.Columns.Add("Thành tiền", System.Type.GetType("System.Int32"));
            dgv_Invoice.DataSource = dtInvoice;
            txt_Total_Amount.Text = "Tổng tiền: 0 VND";
/*            guna2DateTimePicker1.MaxDate = DateTime.Now;
            dtp_Invoice_Date.MaxDate = DateTime.Now;*/
            ThemdgvInvoice();
        }
        void ThemdgvInvoice()
        {
            dtInvoice.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<CHITIETHOADONSACH> listCTHoadonsach = cont.CHITIETHOADONSACHes.ToList();
            List<CHITIETHOADONSP> listCTHoadonsp = cont.CHITIETHOADONSPs.ToList();
            List<HOADON> listHoadon = cont.HOADONs.ToList();
            foreach(HOADON a in listHoadon)
            {
                int Thanhtien = 0;
                foreach(CHITIETHOADONSACH b in listCTHoadonsach)
                {
                    int masach = 0;
                    if (a.SOHD == b.SOHD)
                    {
                        masach = b.MASACH;
                    }
                    int giaban = 0;
                    foreach (SACH c in listSach)
                    {
                        if (masach == c.MASACH)
                        {
                            giaban =Convert.ToInt32( c.GIABAN);
                        }
                    }
                    Thanhtien = Thanhtien + giaban *Convert.ToInt32( b.SOLUONG);
                }
                foreach (CHITIETHOADONSP b in listCTHoadonsp)
                {
                    int masp = 0;
                    if (a.SOHD == b.SOHD)
                    {
                        masp=b.MASP;
                    }
                    int giaban = 0;
                    foreach (SANPHAM c in listSanpham)
                    {
                        if (masp == c.MASP)
                        {
                            giaban = Convert.ToInt32(c.GIABAN);
                        }
                    }
                    Thanhtien = Thanhtien + giaban * Convert.ToInt32(b.SOLUONG);
                }
                dtInvoice.Rows.Add(new object[] { a.SOHD, a.NGAYLAPHOADON, Thanhtien });
            }
            txt_Total_Amount.Text = "Tổng tiền: " + Tongtien().ToString() + "VND";
        }
        int  Tongtien()
        {
            int t = 0;
            for(int i=0; i<dgv_Invoice.RowCount; i++)
            {
                t = t + Convert.ToInt32 (dgv_Invoice.Rows[i].Cells[2].Value);
            }
            return t;
        }

        private void chkB_Access_Invoice_CheckedChanged(object sender, EventArgs e)
        {

            if (chkB_Access_Invoice.Checked == true)
            {
                guna2DateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtp_Invoice_Date.Value = guna2DateTimePicker1.Value.AddMonths(1).AddDays(-1);
                Hienthitheongay();
            }
            else
            {
                ThemdgvInvoice();
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Hienthitheongay();
        }

        private void dtp_Invoice_Date_ValueChanged(object sender, EventArgs e)
        {
            Hienthitheongay();
        }
        void Hienthitheongay()
        {
            dtInvoice.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<CHITIETHOADONSACH> listCTHoadonsach = cont.CHITIETHOADONSACHes.ToList();
            List<CHITIETHOADONSP> listCTHoadonsp = cont.CHITIETHOADONSPs.ToList();
            List<HOADON> listHoadon = cont.HOADONs.ToList();
            foreach (HOADON a in listHoadon)
            {
                if(a.NGAYLAPHOADON<=dtp_Invoice_Date.Value && a.NGAYLAPHOADON>= guna2DateTimePicker1.Value)
                {
                    int Thanhtien = 0;
                    foreach (CHITIETHOADONSACH b in listCTHoadonsach)
                    {
                        int masach = 0;
                        if (a.SOHD == b.SOHD)
                        {
                            masach = b.MASACH;
                        }
                        int giaban = 0;
                        foreach (SACH c in listSach)
                        {
                            if (masach == c.MASACH)
                            {
                                giaban = Convert.ToInt32(c.GIABAN);
                            }
                        }
                        Thanhtien = Thanhtien + giaban * Convert.ToInt32(b.SOLUONG);
                    }
                    foreach (CHITIETHOADONSP b in listCTHoadonsp)
                    {
                        int masp = 0;
                        if (a.SOHD == b.SOHD)
                        {
                            masp = b.MASP;
                        }
                        int giaban = 0;
                        foreach (SANPHAM c in listSanpham)
                        {
                            if (masp == c.MASP)
                            {
                                giaban = Convert.ToInt32(c.GIABAN);
                            }
                        }
                        Thanhtien = Thanhtien + giaban * Convert.ToInt32(b.SOLUONG);
                    }
                    dtInvoice.Rows.Add(new object[] { a.SOHD, a.NGAYLAPHOADON, Thanhtien });
                }
                txt_Total_Amount.Text = "Tổng tiền: " + Tongtien().ToString() + "VND";
            }
        }
        private void btn_Export_Invoice_Click(object sender, EventArgs e)
        {
            if (Sohd != 0)
            {
                InHDchitiet(Sohd);
                FrmHoadonchitiet a = new FrmHoadonchitiet();
                a.Show();
                Sohd = 0;
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn cần xem");
            }
        }
        void InHDchitiet(int mahd)
        {
            if (mahd != 0)
            {
                listDHchitiet = new List<Hoadon>();
                Hoadon hoadon ;
                FahasaContextDB cont = new FahasaContextDB();
                List<SACH> listSach = cont.SACHes.ToList();
                List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                List<CHITIETHOADONSACH> listCTHoadonsach = cont.CHITIETHOADONSACHes.ToList();
                List<CHITIETHOADONSP> listCTHoadonsp = cont.CHITIETHOADONSPs.ToList();
                List<HOADON> listHoadon = cont.HOADONs.ToList();
                foreach(CHITIETHOADONSACH a in listCTHoadonsach)
                {
                    hoadon = new Hoadon();
                    hoadon.Mahd = mahd;
                    foreach (HOADON b in listHoadon)
                    {
                        if (b.SOHD == mahd)
                        {
                            hoadon.Ngaylap = Convert.ToDateTime(b.NGAYLAPHOADON.ToString()).ToShortDateString();
                        }
                    }
                    if ( a.SOHD==mahd)
                    {
                        hoadon.Ma = a.MASACH;
                        hoadon.Soluong =Convert.ToInt32( a.SOLUONG);
                        foreach (SACH b in listSach)
                        {
                            if (a.MASACH == b.MASACH)
                            {
                                hoadon.Tensach = b.TENSACH;
                                hoadon.Giaban = Convert.ToInt32(b.GIABAN);
                                hoadon.Thanhtien = hoadon.Soluong * hoadon.Giaban;
                                hoadon.Tensp = "";
                            }
                        }
                        listDHchitiet.Add(hoadon);
                    }
                }
                foreach (CHITIETHOADONSP a in listCTHoadonsp)
                {
                    hoadon = new Hoadon();
                    hoadon.Mahd = mahd;
                    foreach (HOADON b in listHoadon)
                    {
                        if (mahd==b.SOHD)
                        {
                            hoadon.Ngaylap = Convert.ToDateTime(b.NGAYLAPHOADON.ToString()).ToShortDateString();
                        }
                    }
                    if (mahd == a.SOHD)
                    {
                        hoadon.Ma = a.MASP;
                        hoadon.Soluong = Convert.ToInt32(a.SOLUONG);
                        foreach (SANPHAM b in listSanpham)
                        {
                            if (a.MASP == b.MASP)
                            {
                                hoadon.Tensp=b.TENSP;
                                hoadon.Giaban = Convert.ToInt32(b.GIABAN);
                                hoadon.Thanhtien = hoadon.Soluong * hoadon.Giaban;
                                hoadon.Tensach = "";
                            }
                        }
                        listDHchitiet.Add(hoadon);
                    }
                }

            }
        }
        private void dgv_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Sohd = Convert.ToInt32(dgv_Invoice.Rows[e.RowIndex].Cells["Mã hóa đơn"].FormattedValue.ToString());
            }
        }
        void Tinhdaonhthu()
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<CHITIETHOADONSACH> listCTHoadonsach = cont.CHITIETHOADONSACHes.ToList();
            List<CHITIETHOADONSP> listCTHoadonsp = cont.CHITIETHOADONSPs.ToList();
            List<HOADON> listHoadon = cont.HOADONs.ToList();
            listDoanhthu = new List<Doanthungay>();
            int[] sohd = new int[listHoadon.Count];
            int n = 0;
            foreach (HOADON a in listHoadon)
            {
                if (Convert.ToDateTime(a.NGAYLAPHOADON).ToShortDateString() == dtpDoanhthu.Value.ToShortDateString())
                {
                    sohd[n] = a.SOHD;
                    n = n + 1;
                }
            }
            int[] masch = new int[listSach.Count];
            int[] DemSLsach = new int[listSach.Count];
            int x = 0;
            int y = 0;
            int[] masp = new int[listSanpham.Count];
            int[] DemSLsp = new int[listSanpham.Count];
            for (int i = 0; i < n+1; i++)
            {
                foreach (CHITIETHOADONSACH a in listCTHoadonsach)
                {
                    if (sohd[i] == a.SOHD)
                    {
                        masch[x] = a.MASACH;
                        DemSLsach[x] = Convert.ToInt32(a.SOLUONG);
                        x = x + 1;
                    }
                }
                foreach (CHITIETHOADONSP a in listCTHoadonsp)
                {
                    if (sohd[i] == a.SOHD)
                    {
                        masp[y] = a.MASP;
                        DemSLsp[y] = Convert.ToInt32(a.SOLUONG);
                        y = y + 1;
                    }
                }
            }
            TimsoluongbanSach(masch,DemSLsach,x,listDoanhthu);
            TimsoluongbanSp(masp,DemSLsp,y,listDoanhthu);
        }
        void  TimsoluongbanSach(int[] ma, int[] sl,int n,List<Doanthungay>Listdoanhtu)
        {
            Doanthungay doanhthu;
            for (int i = 0; i < n; i++)
            {
                if (sl[i] != 0)
                {
                    doanhthu = new Doanthungay();
                    doanhthu.Soluongban = sl[i];
                    for (int j = i + 1; j < n+1; j++)
                    {
                        if (ma[j] == ma[i])
                        {
                            doanhthu.Soluongban = doanhthu.Soluongban + sl[j];
                            sl[j] = 0;
                        }
                    }
                    doanhthu.Ma = ma[i];
                    doanhthu.Ngayban = Convert.ToDateTime(dtpDoanhthu.Value).ToShortDateString();
                    doanhthu.Soluongban = sl[i];
                    FahasaContextDB cont = new FahasaContextDB();
                    List<SACH> listSach = cont.SACHes.ToList();
                    foreach (SACH a in listSach)
                    {
                        if (ma[i] == a.MASACH)
                        {
                            doanhthu.Tensp = "";
                            doanhthu.Tensach = a.TENSACH;
                            doanhthu.Giaban = Convert.ToInt32(a.GIABAN);
                            doanhthu.Giamua = Convert.ToInt32(a.GIAMUA);
                            doanhthu.Doanhthu=(doanhthu.Giaban - doanhthu.Giamua)*doanhthu.Soluongban;
                            Listdoanhtu.Add(doanhthu);
                        }
                    }
                }

            }
        }
        void TimsoluongbanSp(int[] ma, int[] sl, int n, List<Doanthungay> Listdoanhtu)
        {
            Doanthungay doanhthu;
            for (int i = 0; i < n ; i++)
            {
                if (sl[i] != 0)
                {
                    doanhthu = new Doanthungay();
                    doanhthu.Soluongban = sl[i];

                    for (int j = i + 1; j < n+1; j++)
                    {
                        if (ma[j] == ma[i])
                        {
                            doanhthu.Soluongban = doanhthu.Soluongban+sl[j];
                            sl[j] = 0;
                        }
                    }
                    doanhthu.Ma = ma[i];
                    doanhthu.Ngayban = Convert.ToDateTime(dtpDoanhthu.Value).ToShortDateString();
                    FahasaContextDB cont = new FahasaContextDB();
                    List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                    foreach (SANPHAM a in listSanpham)
                    {
                        if (ma[i] == a.MASP)
                        {
                            doanhthu.Tensp = a.TENSP;
                            doanhthu.Tensach = "";
                            doanhthu.Giaban = Convert.ToInt32(a.GIABAN);
                            doanhthu.Giamua = Convert.ToInt32(a.GIAMUA);
                            doanhthu.Doanhthu = (doanhthu.Giaban - doanhthu.Giamua) * doanhthu.Soluongban;
                            Listdoanhtu.Add(doanhthu);
                        }
                    }
                }

            }
        }
        private void btnDoanthu_Click(object sender, EventArgs e)
        {
            Tinhdaonhthu();
            FrmDoanhthu a = new FrmDoanhthu();
            a.Show();
        }
    }
}
