using GymFitnessOlympic.Models;
using GymFitnessOlympic.View.Utils;
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
    public partial class FrmGiamGiaEdit : BaseDialog
    {
       public GiamGia ct;
       public FrmGiamGiaEdit(GiamGia c)
        {
            InitializeComponent();
            ct = c;
            txtTenGiamGia.Text = ct.TenGiamGia;
            dtpNgayBatDau.Value = c.NgayBatDau;
            dtpNgayKetThuc.Value = c.NgayKetThuc;
           if(ct != null){
               txtTenGiamGia.Text = ct.TenGiamGia;
               dtpNgayBatDau.Value = ct.NgayBatDau;

           }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenGiamGia.Text == "")
                {
                    dxErrorProvider1.SetError(txtTenGiamGia, "Chưa nhập tên giảm giá");
                    txtTenGiamGia.Focus();
                    return;
                }
                DateTime ngayBatDau = dtpNgayBatDau.Value, ngayKetThuc = dtpNgayKetThuc.Value;
                if (ngayBatDau.Year == 1900)
                {
                    dxErrorProvider1.SetError(dtpNgayBatDau, "Ngày bắt đầu không hợp lệ");
                    dtpNgayBatDau.Focus();
                    return;
                }
                if (ngayKetThuc.Year == 1900)
                {
                    dxErrorProvider1.SetError(dtpNgayKetThuc, "Ngày kết thúc không hợp lệ");
                    dtpNgayKetThuc.Focus();
                    return;
                }
                
                Close();
            }
            catch {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra dữ liệu nhập vào");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
