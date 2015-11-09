using GymFitnessOlympic.Models.entity;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Controller
{
    class KhachLeController
    {
        public static CODE_RESULT_RETURN Add(KhachLe k) {
            using (var db = DBContext.GetContext()) {
                try
                {
                    db.KhachLe.Add(k);
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                catch {
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }
    }
}
