using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Models;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.View.Utils;

namespace GymFitnessOlympic.View.UserControls
{
    public partial class QLHoiVien : UserControl
    {
        List<HoiVien> all;
        public QLHoiVien()
        {
            InitializeComponent();
            dgrHoiVien.AutoGenerateColumns = false;
            DataFiller.fillPhongCombo(cbbPhong1, append:true);
            //gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
        }


     

        void loadData()
        {
            var p = (PhongTap)cbbPhong1.SelectedItem;
            all = HoiVienController.GetList(phongID: p.MaPhongTap);
            updateTable(all);
            //gridControl1.DataSource = all;
        }

        void updateTable(List<HoiVien> li)
        {
            dgrHoiVien.DataSource = li;
        }

        void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.Name =="GioiTinh") {
            //    e.DisplayText = Convert.ToBoolean(e.Value) == true ? "Nam" : "Nữ";
            //    e.Column.
            //}
        }






        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = openFileDialog1.FileName;
        }

        private void QLHoiVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgw = (DataGridView)sender;
            DataGridViewColumn column = dgw.Columns[e.ColumnIndex];
            DataGridViewRow row = dgw.Rows[e.RowIndex];

            if (column.DataPropertyName.Contains("."))
            {
                e.Value = BindingHelper.GetPropertyValue(row.DataBoundItem, column.DataPropertyName);
            }
            if (e.ColumnIndex == 1)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var hv = (HoiVien)dgrHoiVien.SelectedRows[0].DataBoundItem;


            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FrmHoiVienEdit edit = new FrmHoiVienEdit();
            edit.ShowDialog();
            if (edit.DialogResult == DialogResult.OK)
            {
                loadData();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                HoiVien v = (HoiVien)dgrHoiVien.SelectedRows[0].DataBoundItem;
                FrmHoiVienEdit edit = new FrmHoiVienEdit(v);
                edit.ShowDialog();
                if (edit.DialogResult == DialogResult.OK)
                {
                    loadData();
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        List<HoiVien> Search(string s)
        {
            var li = all.Where(h => h.TenHoiVien.ToUpper().Contains(s.ToUpper())
                || h.MaThe.ToUpper().Contains(s.ToUpper())).ToList();
            return li;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmHoiVienEdit f = new FrmHoiVienEdit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var h = (HoiVien)dgrHoiVien.SelectedRows[0].DataBoundItem;
                FrmHoiVienEdit f = new FrmHoiVienEdit(h);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrHoiVien.SelectedRows.Count > 0)
            {
                var h = (HoiVien)dgrHoiVien.SelectedRows[0].DataBoundItem;
                if (!HoiVienController.IsKhongRangBuoc(h))
                {
                    MessageBox.Show("Không thể xóa do còn dữ liệu liên quan");
                    return;
                }
                if (DialogUtils.Confirmed("Bạn có thực sự muốn xóa") != true)
                {
                    return;
                }
                if (HoiVienController.Delete(h.MaHoiVien) == CODE_RESULT_RETURN.ThanhCong)
                {
                    loadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa");

                }
            }
            else
            {
                MessageBox.Show("Chọn một hội viên để xóa");
            }
        }

        private void lblChucNang_Click(object sender, EventArgs e)
        {

        }

        private void cbbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var p = (PhongTap)cbbPhong1.SelectedItem;
            if (p != null)
            {
                var hvs = HoiVienController.GetList(p.MaPhongTap);
                dgrHoiVien.DataSource = hvs;
            }
        }



    }
}
