using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GymFitnessOlympic.View.Dialog;
using DevExpress.Charts.Native;
using GymFitnessOlympic.Models.Util;

namespace GymFitnessOlympic.Controller
{
    class HistoryHoiVienController
    {
        internal static List<HistoryHoiVien> GetList(int phongID = -1 , bool isSauna = false)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.HistoryHoiVien.Include(d=>d.HoiVien.PhongTap);
                if (phongID != -1) {
                    nvs = nvs.Where(d=>d.HoiVien.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }

        

        public DateTime GetExpireDay(string code, bool isSauna) {
            using (var db = DBContext.GetContext()) {
                var h =  db.HoiVien.FirstOrDefault(p => p.MaThe == code);
                if (!isSauna){
                    return h.NgayHetHanGYM;
                }
                return h.NgayHetHanSauNa;
                    
            }
        }

        internal static HistoryHoiVien GetByID(DateTime thoiGian)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryHoiVien.FirstOrDefault(n => n.ThoiGian == thoiGian);
                return nv;
            }
        }


        internal static CODE_RESULT_RETURN Add(HistoryHoiVien sp )
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.HistoryHoiVien.FirstOrDefault(n => n.ThoiGian == sp.ThoiGian);
                    if (n1 == null)
                    {
                        var hv = context.HoiVien.Find(sp.HoiVien.MaHoiVien);
                        sp.HoiVien = hv;
                        sp.IsDaInGYM = false;
                        sp.IsDaInSauna = false;
                        context.HistoryHoiVien.Add(sp);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    return CODE_RESULT_RETURN.MaTrung;
                }
                catch
                {
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }

       
        internal static CODE_RESULT_RETURN Delete(DateTime id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.HistoryHoiVien.FirstOrDefault(p => p.ThoiGian == id);
                if (pt != null)
                {
                    context.HistoryHoiVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        public static CODE_RESULT_RETURN InPhieuCoCapNhat(HistoryHoiVien hs, bool isGYM) {
            try
            {
                FrmInPhieu f = new FrmInPhieu(hs, isGYM);
                using (var db = DBContext.GetContext()) {
                    var oldHS = db.HistoryHoiVien.Find(hs.ThoiGian);
                    if (isGYM)
                    {
                        oldHS.IsDaInGYM = true;
                    }
                    else {
                        oldHS.IsDaInSauna = true;
                    }
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
            }
            catch (Exception ex) {
                return CODE_RESULT_RETURN.ThatBai;
            }
        }



        internal static HistoryHoiVien GetHisToDay(string ma)
        {
            using (var context = DBContext.GetContext())
            {
                var start = DateTimeUtil.StartOfDay(DateTime.Now);
                var end = DateTimeUtil.EndOfDay(DateTime.Now);
                var pt = context.HistoryHoiVien.Include(h=>h.HoiVien).FirstOrDefault(p => p.ThoiGian >=  start &&
                    p.ThoiGian <= end 
                    && p.HoiVien.MaThe == ma);
                if (pt != null)
                {
                    return pt;
                }
                return null;
            }
        }

        internal static List<HistoryHoiVien> GetToDay()
        {
            using (var db = DBContext.GetContext()) { 
                var start = DateTimeUtil.StartOfDay(DateTime.Now);
                var end = DateTimeUtil.EndOfDay(DateTime.Now);
                return db.HistoryHoiVien.Include(h => h.HoiVien).Where(h => h.ThoiGian >= start
                    && h.ThoiGian <= end).ToList();
            }
        }



    }
}
