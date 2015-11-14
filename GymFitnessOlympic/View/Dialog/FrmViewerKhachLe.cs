using DevExpress.XtraReports.UI;
using GymFitnessOlympic.Models.entity;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmInPhieu : Form
    {
        private Models.HoiVien hv;
        private bool p;
        XtraReport rp;
        private Models.HistoryHoiVien hs;

        public FrmInPhieu() {
            InitializeComponent();
        }

        public FrmInPhieu(KhachLe kl):base()
        {
            InitializeComponent();
            rp = new RpKhachLe();
            printControl1.PrintingSystem = rp.PrintingSystem;
            rp.Parameters["LoaiVe"].Value = kl.LoaiVe;
            rp.Parameters["ToDay"].Value =DateTimeUtil.dateToString( DateTime.Now);
            rp.Parameters["TenHoiVien"].Value = "Khách lẻ";
            rp.Parameters["MaGYM"].Value = "Không có";
           // rp.CreateDocument();
            inPhieu();
        }

        void inPhieu() {
            rp.Print();
            //Close();
        }

        public FrmInPhieu(Models.HoiVien hv, bool IsGYM) : base()
        {
            InitializeComponent();
            this.hv = hv;
            this.p = IsGYM;
            rp = new RpKhachLe();
            printControl1.PrintingSystem = rp.PrintingSystem;
            rp.Parameters["LoaiVe"].Value = IsGYM ? "GYM" : "Sauna";
            rp.Parameters["ToDay"].Value = DateTimeUtil.dateToString(DateTime.Now);
            rp.Parameters["TenHoiVien"].Value = hv.TenHoiVien;
            rp.Parameters["MaGYM"].Value = hv.MaThe;
            //rp.CreateDocument();
            inPhieu();
        }

        public FrmInPhieu(Models.HistoryHoiVien hs, bool isGYM)
        {
            InitializeComponent();
            var hv = hs.HoiVien;
            rp = new RpKhachLe();
            printControl1.PrintingSystem = rp.PrintingSystem;
            rp.Parameters["LoaiVe"].Value = isGYM ? "GYM" : "Sauna";
            rp.Parameters["ToDay"].Value = DateTimeUtil.dateToString(DateTime.Now);
            rp.Parameters["TenHoiVien"].Value = hv.TenHoiVien;
            rp.Parameters["MaGYM"].Value = hv.MaThe;
            //rp.CreateDocument();
            inPhieu();
        }

      

        private void FrmViewerKhachLe_Load(object sender, EventArgs e)
        {

            
        }
    }
}
