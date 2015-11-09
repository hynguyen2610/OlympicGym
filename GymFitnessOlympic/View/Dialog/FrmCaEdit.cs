using GymFitnessOlympic.Controller;
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
    public partial class FrmCaEdit : BaseDialog
    {
        CaLamViec current;

        public FrmCaEdit(CaLamViec ca)
        {
            InitializeComponent();
            current = ca;
            spnGioBatDau.Text = ca.GioBatDau.Hours.ToString();
            spnPhutBatDau.Text = ca.GioBatDau.Minutes.ToString();
            spnGioKetThuc.Text = ca.GioKetThuc.Hours.ToString();
            spnPhutKetThuc.Text = ca.GioKetThuc.Minutes.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (spnGioBatDau.Value < 0) {
                dxErrorProvider1.SetError(spnGioBatDau, "Giờ bắt đầu không được nhỏ hơn 0");
                spnGioBatDau.Focus();
                return;
            }
            if (spnPhutBatDau.Value < 0)
            {
                dxErrorProvider1.SetError(spnPhutBatDau, "Phút bắt đầu không được nhỏ hơn 0");
                spnPhutBatDau.Focus();
                return;
            }
            if (spnGioKetThuc.Value < 0)
            {
                dxErrorProvider1.SetError(spnGioKetThuc, "Giờ kết thúc không được nhỏ hơn 0");
                spnGioKetThuc.Focus();
                return;
            }
            if (spnPhutKetThuc.Value < 0)
            {
                dxErrorProvider1.SetError(spnPhutKetThuc, "Phút kết thúc không được nhỏ hơn 0");
                spnGioBatDau.Focus();
                return;
            }
            current.GioBatDau = new TimeSpan(Convert.ToInt32(spnGioBatDau.Text), Convert.ToInt32(spnPhutBatDau.Text), 0);
            current.GioKetThuc = new TimeSpan(Convert.ToInt32(spnGioKetThuc.Text), Convert.ToInt32(spnPhutKetThuc.Text), 0);
            var t = CaLamViecController.Update(current);
            switch (t) { 
                case CODE_RESULT_RETURN.MaTrung:
                    MessageBox.Show("Lỗi: Có sự chồng lấp thời gian giữa các ca");
                    return;
                case CODE_RESULT_RETURN.ThanhCong:
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Cập nhật thành công");
                    return;
                default:
                    MessageBox.Show("Lỗi khi cập nhật");
                    return;  
            }
        }

        private void spnGioBatDau_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var t = int.Parse( e.NewValue.ToString());
            if (t < 0) {
                t = 0;
                return;
            }
        }

        private void spnPhutBatDau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void spnPhutBatDau_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var t = int.Parse(e.NewValue.ToString());
            if (t < 0)
            {
                return;
            }
        }

        private void spnGioKetThuc_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var t = int.Parse(e.NewValue.ToString());
            if (t < 0)
            {
                return;
            }
        }

        private void spnPhutKetThuc_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var t = int.Parse(e.NewValue.ToString());
            if (t < 0)
            {
                return;
            }
        }
    }
}
