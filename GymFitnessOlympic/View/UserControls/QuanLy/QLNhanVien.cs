﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Systems;

namespace GymFitnessOlympic.View.UserControls
{
    public partial class QLNhanVien : UserControl
    {
        List<NhanVien> all;

        public QLNhanVien()
        {
            InitializeComponent();
            dgrNhanVien.AutoGenerateColumns = false;
            loadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0) {
                var nv = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                if (!NhanVienController.IsKhongRangBuoc(nv))
                {
                    MessageBox.Show("Không thể xóa do còn dữ liệu liên quan");
                    return;
                }
                if (nv.MaNhanVien == Login1.TaiKhoanHienTai.MaNhanVien) {
                    MessageBox.Show("Tài khoản này hiện đang đăng nhập, không thể xóa");
                    return;
                }
                if (NhanVienController.Delete(nv.MaNhanVien) == CODE_RESULT_RETURN.ThanhCong)
                {
                    MessageBox.Show("Đã xóa");
                    loadData();
                }
                else {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
            else {
                MessageBox.Show("Chọn nhân viên để xóa");
            }
        }

     

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                NhanVien v = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                FrmNhanVienEdit edit = new FrmNhanVienEdit(v);
                edit.ShowDialog();
                if (edit.DialogResult == DialogResult.OK)
                {
                    loadData();
                }
            }
        }

        void loadData()
        {
            all = NhanVienController.GetList();
            updateTable(all);
            //gridControl1.DataSource = all;
        }

        void updateTable(List<NhanVien> li) {
            dgrNhanVien.DataSource = li;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FrmNhanVienEdit edit = new FrmNhanVienEdit();
            if (edit.ShowDialog() == DialogResult.OK) {
                loadData();
            }
        }

     

        private void dgrNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrNhanVien.SelectedRows.Count > 0)
            {
                var a = (NhanVien)dgrNhanVien.SelectedRows[0].DataBoundItem;
                if (a.Anh != null)
                {
                    imgAnh.Image = StreamUtil.byteArrayToImage(a.Anh);

                }
                else
                {
                    imgAnh.Image = null;
                }
            }
        }


        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePassword f = new FormChangePassword(Login1.GetTaiKhoanHienTai());
        }
    }
}
