using GymFitnessOlympic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Utils;

namespace GymFitnessOlympic.View.ActForm.ThongKe
{
    public partial class FrmLichSuNhanVien : UserControl
    {
        List<HistoryNhanVien> danhSachLichSu;
        bool isGym;
        public FrmLichSuNhanVien(bool isGYM = true)
        {
            InitializeComponent();
            this.isGym = isGYM;
            dataGridView1.AutoGenerateColumns = false;

            cbbInOut.SelectedIndex = isGYM ? 0 : 1;
            loadData();
            loc();
            for (int i = 2010; i < 2250; i++)
            {
                cbbTheoThangNam.Items.Add(i);

            }
            cbbTheoThangNam.SelectedIndex = cbbTheoThangThang.SelectedIndex = 0;
            cbbTheoThangThang.SelectedValue = DateTime.Now.Month;
            DataFiller.fillPhongCombo(cbbPhong, append:true);
            loadNhanVien();
        }

        private void FrmLichSuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            loc();
        }

        private void cbbInOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loc();
        }
        void loc()
        {
            try
            {
                var phong = (PhongTap)cbbPhong.SelectedItem;
                var nhanVien = (NhanVien)cbbNhanVien.SelectedItem;
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
                    start = dtpFrom.Value;
                    end = dtpTo.Value;
                }
                start = DateTimeUtil.StartOfDay(start);
                end = DateTimeUtil.EndOfDay(end);
                //finish day select
                IEnumerable<HistoryNhanVien> li = HistotyNhanVienController.GetList(start, end);
                

                li = li.Where(h => h.ThoiGian.CompareTo(start) >= 0 && h.ThoiGian.CompareTo(end) <= 0
                    );
                var mode = cbbInOut.SelectedIndex;
                switch (mode) { 
                    case 1:
                        li = li.Where(h => h.IsCheckin == true);
                        break;
                    case 2:
                        li = li.Where(h => h.IsCheckin == false);
                        break;
                }
                if (phong.MaPhongTap != -1) {
                    li = li.Where(l=>l.NhanVien.PhongTap.MaPhongTap == phong.MaPhongTap);
                }
                if (nhanVien.MaNhanVien != -1) {
                    li = li.Where(l => l.NhanVien.MaNhanVien == nhanVien.MaNhanVien);
                }
                updateTable(li.ToList());

            }
            catch {
                //MessageBox.Show("Có lỗi khi loch");
            }
        }

        void loadData()
        {

            var isGym = cbbInOut.SelectedIndex == 0;
           // int mode = cbbInOut.SelectedIndex;
            danhSachLichSu = HistotyNhanVienController.GetList(0);
            
            //updateTable(danhSachLichSu);
        }
        void updateTable(List<HistoryNhanVien> li)
        {
            dataGridView1.DataSource = li;
        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnTim_Click(null, null);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           if(  dataGridView1.Columns[e.ColumnIndex].Name == "tgThucTe"
                ||
                dataGridView1.Columns[e.ColumnIndex].Name == "tgDung"){
            
            if (e.Value != null && e.Value != DBNull.Value)
                e.Value = ((TimeSpan)e.Value).Hours.ToString("00") + ":" +
                           ((TimeSpan)e.Value).Minutes.ToString("00");
                }
            //var hvh = (HistoryNhanVien)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //if (e.ColumnIndex == 0)
            //{
            //    e.Value = hvh.NhanVien.MaThe;
            //}
            //if (e.ColumnIndex == 1)
            //{
            //    e.Value = hvh.NhanVien.TenNhanVien;
            //}
            //if (e.ColumnIndex == 2) {
            //    e.Value = hvh.IsCheckin ? "Checkin" : "Checkout";
            //}
            //if (e.ColumnIndex == 4) {
            //    e.Value = (hvh.IsCheckin) ? DateTimeUtil.timeToString(hvh.Ca.GioBatDau) : DateTimeUtil.timeToString(hvh.Ca.GioKetThuc);
            //}
            //if (e.ColumnIndex == 5)
            //{
            //    e.Value = DateTimeUtil.timeToString( hvh.ThoiGian.TimeOfDay);
            //}
           
        }

        private void cbbTheoThangThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(rdTheoThang.Checked)
           // loc();
        }

        private void rdTheoQuy_CheckedChanged(object sender, EventArgs e)
        {
           // if (rdTheoQuy.Checked)
               // loc();
        }

        private void rdTheoKhoangNgay_CheckedChanged(object sender, EventArgs e)
        {
           // if (rdTheoKhoangNgay.Checked)
               // loc();
        }

        private void cbbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadNhanVien();
            //loc();
        }

        private void loadNhanVien()
        {
            if (cbbPhong.SelectedItem != null)
            {
                var phong = (PhongTap)cbbPhong.SelectedItem;
                DataFiller.fillNhanVienCombo(cbbNhanVien, phong.MaPhongTap, true);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >0){
                var r = (HistoryNhanVien)dataGridView1.SelectedRows[0].DataBoundItem;
                int tongPhut = danhSachLichSu.Where(d => d.NhanVien.MaNhanVien == r.NhanVien.MaNhanVien).
                    Sum(d => d.ChenhLech);
                lblTongChenhLech.Text = tongPhut.ToString().FormatCurrency();
            }
        }
    }
}
