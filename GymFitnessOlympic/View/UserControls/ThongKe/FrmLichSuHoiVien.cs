using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmLichSuHoiVien : UserControl
    {
        List<HistoryHoiVien> danhSachLichSu;
        bool isGym;
        public FrmLichSuHoiVien(bool isGYM = true)
        {
            InitializeComponent();
            this.isGym = isGYM;
            dataGridView1.AutoGenerateColumns = false;
            DataFiller.fillPhongCombo(cbbPhong, append:true);
           // cbbGYM.SelectedIndex = isGYM ? 0 : 1;
            loadData();
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoThangNam.Items.Add(i);

            }
            cbbTheoThangThang.SelectedIndex = cbbTheoThangNam.SelectedIndex = 0;
         
        }

        void loadData()
        {

            //var isGym = cbbGYM.SelectedIndex == 0;
            //danhSachLichSu = HistoryHoiVienController.GetList(Login.GetPhongHienTai().MaPhongTap, isGym);
            danhSachLichSu = HistoryHoiVienController.GetList();
            updateTable(danhSachLichSu);
        }
        void updateTable(List<HistoryHoiVien> li)
        {
            dataGridView1.DataSource = li;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            loc();
        }

        void loc()
        {
            try
            {
                DateTime start = new DateTime(), end = new DateTime();
                if (rdTheoThang.Checked)
                {
                    int month = int.Parse(cbbTheoThangThang.Text.ToString());
                    int year = int.Parse(cbbTheoThangNam.Text.ToString());
                    start = new DateTime(year, month, 1);
                    end = start.AddMonths(1).AddDays(-1);
                }
                
                else if (rdTheoKhoangNgay.Checked)
                {
                    start =DateTimeUtil.StartOfDay( dtpFrom.Value);
                    end =DateTimeUtil.EndOfDay(  dtpTo.Value);
                }
                var phong = (PhongTap)cbbPhong.SelectedItem;
                IEnumerable<HistoryHoiVien> li = HistoryHoiVienController.GetList(phong.MaPhongTap);
                
                li = li.Where(h => h.ThoiGian.CompareTo(start) >= 0
                    && h.ThoiGian.CompareTo(end) <= 0
                    
                    );
                if (phong.MaPhongTap != -1) {
                    li = li.Where(h=>h.HoiVien.PhongTap.MaPhongTap == phong.MaPhongTap);
                }
                updateTable(li.ToList());
            }
            catch { }
        }

        void locDuLieu(DateTime start, DateTime end, int cheDoTim = 0, int locTheo = 0, String queryString = "")
        {
            var li = new List<HistoryHoiVien>();
            switch (cheDoTim)
            {
                case 0:
                    break;
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnTim_Click(null, null);
            }
        }

        private void cbbTheoThangThang_SelectedIndexChanged(object sender, EventArgs e)
        {
           // loc();
        }

        private void cbbTheoThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loc();
        }

        private void rdTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            //loc();
        }

        private void rdTheoQuy_CheckedChanged(object sender, EventArgs e)
        {
            //loc();
        }

        private void rdTheoKhoangNgay_CheckedChanged(object sender, EventArgs e)
        {
          //  loc();
        }
    }
}
