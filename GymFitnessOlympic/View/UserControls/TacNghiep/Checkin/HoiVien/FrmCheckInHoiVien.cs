using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.View.Utils;
using GymFitnessOlympic.Utils;
using GymFitnessOlympic.Properties;

namespace GymFitnessOlympic.View.MainForms
{
    public partial class FrmCheckinHoiVien : UserControl
    {
        HoiVien hv;
        KetQuaCheckin validCardGYM = KetQuaCheckin.KhongTonTai;
        KetQuaCheckin validCardSauna = KetQuaCheckin.KhongTonTai;

        public FrmCheckinHoiVien(bool isGym = true)
        {
            InitializeComponent();
            loadDefault();
            dataGridView1.AutoGenerateColumns = false;
            loadGrid();
            lblThongBao.Text = "";
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

            wipeCard();
        }

        void wipeCard()
        {
            loadDefault();
            var st = "";
            if (!string.IsNullOrEmpty(txtMa.Text))
                st = txtMa.Text.Trim();
            else
                if (hv != null)
                    st = hv.MaThe;
            var his = HistoryHoiVienController.GetHisToDay(st);
            bool checkedIn = false;
            if (his != null)
            {
                checkedIn = true;
            }

            hv = HoiVienController.GetByMaHoiVien(st);
            if (hv != null)
            {
                lblThongBao.Text = "";
                //kiem tra gym
                if (hv.NgayHetHanGYM > DateTime.Now)
                {
                    validCardGYM = KetQuaCheckin.TheHopLe;

                }
                if (hv.NgayHetHanSauNa > DateTime.Now)
                {
                    validCardSauna = KetQuaCheckin.TheHopLe;

                }
                var hs = new HistoryHoiVien()
                {
                    HoiVien = hv,
                    ThoiGian = DateTime.Now,
                    IsDaInGYM = false,
                    IsDaInSauna = false
                };
                txtMa.Text = "";
                if (!checkedIn)
                {
                    if (HistoryHoiVienController.Add(hs) == CODE_RESULT_RETURN.ThanhCong)
                    {
                        lblThongBao.Text = "Checkin thành công";
                    }
                    else
                    {
                        DialogUtils.ShowError("Có lỗi khi checkin");
                    }
                }
                else
                {
                    lblThongBao.Text = "Hội viên này đã checkin";
                }
                loadData();

            }
            else
            {
                lblThongBao.Text = "Không tồn tại mã thẻ này";
                loadDefault();
            }
        }

        enum KetQuaCheckin
        {
            TheHopLe,
            KhongTonTai,
            DaHetHan
        }

        private void loadDefault()
        {
            lblKetQuaGYM.ForeColor = lblKetQuaSauna.ForeColor = Color.Red;
            lblThongBao.Text = "Mã thẻ không hợp lệ";
            lblKetQuaGYM.Text = lblKetQuaSauna.Text
                = lblPT_GiaHanCuoi.Text = lblPT_NgayHetHan.Text
                = lblPT_SoNgayConLai.Text = lblSauGiaHanCuoi.Text
                = lblSauNgayHetHan.Text = lblSauSoNgayConLai.Text
                = lblTen.Text = "Không rõ";
        }


        void loadData()
        {
            lblTen.Text = "";
            picAva.Image = Resources.empty_avatar;
            loadGrid();
            if (hv != null)
            {
                lblTen.Text = hv.TenHoiVien;
                lblNgaySinh.Text = DateTimeUtil.dateToString(hv.NgaySinh);
                if (hv.Anh != null)
                    picAva.Image = StreamUtil.byteArrayToImage(hv.Anh);
                lblMaThe.Text = hv.MaThe;
                //Cập nhật text gymn
                lblPT_GiaHanCuoi.Text = DateTimeUtil.dateToString(hv.GiaHanCuoiGYM);
                lblPT_NgayHetHan.Text = DateTimeUtil.dateToString(hv.NgayHetHanGYM);
                var delta = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanGYM - DateTime.Now).TotalDays));
                lblPT_SoNgayConLai.Text = delta.ToString();
                if (delta >= 0)
                {
                    lblKetQuaGYM.ForeColor = Color.Green;
                    lblKetQuaGYM.Text = "Thẻ hợp lệ";
                }
                else
                {
                    lblKetQuaGYM.ForeColor = Color.Red;
                    lblKetQuaGYM.Text = "Đã hết hạn";
                }

                //Cập nhật sauna
                lblSauGiaHanCuoi.Text = DateTimeUtil.dateToString(hv.GiaHanCuoiSauna);
                lblSauNgayHetHan.Text = DateTimeUtil.dateToString(hv.NgayHetHanSauNa);
                var deltaSauNa = Convert.ToInt32(Math.Ceiling((hv.NgayHetHanSauNa - DateTime.Now).TotalDays));
                lblSauSoNgayConLai.Text = deltaSauNa.ToString();
                if (deltaSauNa >= 0)
                {
                    lblKetQuaSauna.ForeColor = Color.Green;
                    lblKetQuaSauna.Text = "Thẻ hợp lệ";
                }
                else
                {
                    lblKetQuaSauna.ForeColor = Color.Red;
                    lblKetQuaSauna.Text = "Đã hết hạn";
                }
            }
        }

        void loadGrid()
        {
            var hs = HistoryHoiVienController.GetToDay();
            MySortableBindingList<HistoryHoiVien> li =
                new MySortableBindingList<HistoryHoiVien>(hs);
            dataGridView1.DataSource = li;
        }

        private void btnGiaHanGYM_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                FrmGiaHan gh = new FrmGiaHan(hv, isGYM: true);
                if (gh.ShowDialog() == DialogResult.OK)
                {
                    wipeCard();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hội viên checkin hiện tại để gia hạn");
            }
            txtMa.Focus();
        }

        private void FrmCheckinHoiVien_Load(object sender, EventArgs e)
        {
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                btnCheckin.PerformClick();
            }
        }

        private void btnInGYM_Click(object sender, EventArgs e)
        {
            yeuCauInPhieu(true);
            txtMa.Focus();
        }

        void yeuCauInPhieu(bool isGYM, HoiVien hoiVien = null)
        {
            var tenPhieu = isGYM ? "GYM" : "Sauna";
            HistoryHoiVien hs = null;
            //Truong hop in tren Grid
            if (hoiVien == null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    hs = (HistoryHoiVien)dataGridView1.SelectedRows[0].DataBoundItem;
                    hoiVien = hs.HoiVien;
                }
                else
                {
                    DialogUtils.ShowMessage("Vui lòng chọn bản ghi muốn in phiếu");
                    return;
                }
            }
            //Truong hop in hoi vien hien tai
            else
            {
                hs = HistoryHoiVienController.GetHisToDay(hoiVien.MaThe);
                if (hs == null)
                {
                    DialogUtils.ShowError("Vui lòng check in trước khi in");
                    return;
                }
            }
            if ((hoiVien.NgayHetHanGYM < DateTime.Now && isGYM) || (hoiVien.NgayHetHanSauNa < DateTime.Now && !isGYM))
            {
                DialogUtils.ShowMessage("Thẻ này đã hết hạn " + tenPhieu);
                //NTHNV022loadData();
                return;
            }
            try
            {
                if ((isGYM && hs.IsDaInGYM)
                    || (!isGYM && hs.IsDaInSauna))
                {
                    DialogUtils.ShowMessage("Đã in phiếu " + tenPhieu + " cho thẻ này trong ngày hôm nay");
                    return;
                }
                var r = HistoryHoiVienController.InPhieuCoCapNhat(hs, isGYM);
                if (r == CODE_RESULT_RETURN.ThatBai)
                {
                    DialogUtils.ShowMessage("Có lỗi khi ghi dữ liệu");
                }
                else
                {
                    loadGrid();
                }
            }
            catch (Exception ex)
            {
                DialogUtils.ShowError("Lỗi. Chi tiết: " + ex.Message);
            }
        }

        private void btnCheckin_Click_1(object sender, EventArgs e)
        {
            wipeCard();
            txtMa.Focus();
        }

        private void btnGiaHanSauna_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                FrmGiaHan gh = new FrmGiaHan(hv, isGYM: false);
                if (gh.ShowDialog() == DialogResult.OK)
                {
                    wipeCard();
                }
            }
            else
            {
                MessageBox.Show("Chưa có hội viên checkin hiện tại để gia hạn");
            }
            txtMa.Focus();
        }

        private void btnInSauna_Click(object sender, EventArgs e)
        {
            yeuCauInPhieu(false);
            txtMa.Focus();
        }

        private void btnInGYMHienTai_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                yeuCauInPhieu(true, hv);
            }
            else
                DialogUtils.ShowError("Vui lòng check in trước");
            txtMa.Focus();
        }

        private void btnInSaunaHienTai_Click(object sender, EventArgs e)
        {
            if (hv != null)
            {
                yeuCauInPhieu(false, hv);
            }
            else
                DialogUtils.ShowError("Vui lòng check in trước");
            txtMa.Focus();
        }
    }
}