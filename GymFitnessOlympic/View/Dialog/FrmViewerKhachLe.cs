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
    public partial class FrmViewerKhachLe : Form
    {
        public FrmViewerKhachLe(KhachLe kl)
        {
            InitializeComponent();
            RpKhachLe rp = new RpKhachLe();
            printControl1.PrintingSystem = rp.PrintingSystem;
            rp.Parameters["LoaiVe"].Value = kl.LoaiVe;
            rp.Parameters["ToDay"].Value =DateTimeUtil.dateToString( DateTime.Now);
            rp.CreateDocument();
        }

      

        private void FrmViewerKhachLe_Load(object sender, EventArgs e)
        {

            
        }
    }
}
