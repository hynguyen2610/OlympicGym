using GymFitnessOlympic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.Models.DataFiller
{
    class DataFiller
    {
        public static void fillPhongCombo(DevExpress.XtraEditors.LookUpEdit cbb, List<PhongTap> l = null)
        {
            if (l == null)
            {
                l = PhongTapController.GetList();
            }
            cbb.Properties.DataSource = l;
            cbb.Properties.ValueMember = "MaPhongTap";
            cbb.Properties.DisplayMember = "TenPhongTap";

        }

        public static void fillPhongCombo(DevExpress.XtraEditors.ComboBoxEdit cbb, List<PhongTap> l = null)
        {
            if (l == null)
            {
                l = PhongTapController.GetList();
            }
            cbb.Properties.Items.Clear();
            foreach (var p in l)
            {
                cbb.Properties.Items.Add(p);
            }
            if (cbb.Properties.Items.Count > 0)
            {
                cbb.SelectedIndex = 0;
            }
        }

        public static void fillPhongCombo(System.Windows.Forms.ComboBox cbb, List<PhongTap> l = null, bool append = false)
        {
            if (l == null)
            {
                l = PhongTapController.GetList();
                if (append)
                {
                    l.Insert(0, new PhongTap() { TenPhongTap = "--Tất cả phòng--", MaPhongTap = -1 });
                }
            }

            cbb.DataSource = l;
            cbb.DisplayMember = "TenPhongTap";
            cbb.ValueMember = "MaPhongTap";
            if (cbb.Items.Count > 0)
            {
                cbb.SelectedIndex = 0;
            }
        }

        public static void fillGiamGiaCombo(System.Windows.Forms.ComboBox cbb, bool chuaNgayHienTai, bool append = false)
        {

            var l = GiamGiaController.GetList(chuaNgayHienTai);

            if (append)
            {
                l.Insert(0, new GiamGia()
                {
                    MaGiamGia = "",
                    TenGiamGia = "--Vui lòng chọn giảm giá--"
                });
            }
            cbb.DataSource = l;
            cbb.DisplayMember = "TenGiamGia";
            cbb.ValueMember = "MaGiamGia";
            if (cbb.Items.Count > 0)
            {
                cbb.SelectedIndex = 0;
            }
        }

        public static void fillGoiCombo(System.Windows.Forms.ComboBox cbb, int typeID, int phongID, List<GoiTap> gois = null)
        {
            if (gois == null)
            {
                gois = GoiTapController.GetList(typeID, phongID);
            }
            cbb.DataSource = gois;
            cbb.DisplayMember = "TenGoiTap";
            cbb.ValueMember = "SoThang";
        }


        public static void fillNhanVienCombo(ComboBox cbb, int maPhong = -1, bool append = false) {
            var nvs = NhanVienController.GetList(phongID: maPhong);
            if (append) {
                nvs.Insert(0, new NhanVien() { TenNhanVien = "--Tất cả nhân viên--", MaNhanVien = -1 });
            }
            cbb.DataSource = nvs;
            cbb.DisplayMember = "TenNhanVien";
            cbb.ValueMember = "MaNhanVien";
        }

    }
}
