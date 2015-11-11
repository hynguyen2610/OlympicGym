using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Utils
{
    public static class StringUtils
    {
        /// <summary>
        /// Tạo số phiếu thu
        /// </summary>
        /// <param name="soPhieu"></param>
        /// <param name="length">Độ dài của số phiếu</param>
        /// <returns></returns>
        public static string GenerateSoPhieu(this string soPhieu, int length = 7)
        {
            if (soPhieu.IsNullOrEmpty())
                return "";
            string rs = soPhieu;
            for (int i = 0; i < length - soPhieu.Length; i++)
                rs = rs.Insert(0, "0");
            return rs;
        }

        public static bool IsNullOrEmpty(this string st)
        {
            return string.IsNullOrEmpty(st);
        }

        public static string TạoChuỗi(char ch, int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
                result += ch;
            return result;
        }

        /// <summary>
        /// Chuyển một số thành chữ
        /// Ex: 123 = một trăm hai mươi ba
        /// </summary>
        /// <param name="value">Chữ của số cần chuyển</param>
        /// <returns></returns>
        public static string ConvertNum2Text(this string value)
        {
            //CHUYỂN 1 SỐ ST THÀNH CHUỖI
            value = value.Replace(".", "").Replace(",", "");
            var result = "";
            var temp = 0L;
            if (!long.TryParse(value, out temp))
            {
                throw new Exception(string.Format("Không thể chuyển số {0} thành chữ", value));
            }
            if (long.Parse(value) == 0L)
                return "không ";
            var i = value.Length - 1;
            while (i >= 2)
            {
                var t = value.Length % 3;
                string str = null;
                if (t != 0)
                {
                    str = value.Substring(0, t);
                    value = value.Remove(0, t);
                }
                else
                {
                    str = value.Substring(0, 3);
                    value = value.Remove(0, 3);
                }
                i = value.Length - 1;
                result = result + Convert3Number(str);
                if (string.IsNullOrEmpty(value))
                {
                    break;
                }
                if (value.Length == 3 | value.Length == 12 | value.Length == 21 | value.Length == 30 | value.Length == 39)
                {
                    if (str != "000")
                    {
                        result = result + "ngàn ";
                    }
                }
                else if (value.Length == 6 | value.Length == 15 | value.Length == 24 | value.Length == 33 | value.Length == 42)
                {
                    if (str != "000")
                    {
                        result = result + "triệu ";
                    }
                }
                else if (value.Length == 9 | value.Length == 18 | value.Length == 27 | value.Length == 36 | value.Length == 45)
                {
                    result = result + "tỷ ";
                }
            }
            result = result + Convert3Number(value);
            return result.UpperCaseFirst();
        }

        static string UpperCaseFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        /// <summary>
        /// Chuyển ba số thành chữ
        /// Hàm này trợ giúp cho hàm Convert2Text
        /// </summary>
        /// <param name="str">Số các chữ số là nhỏ hơn hoặc bằng 3</param>
        /// <returns></returns>
        static string Convert3Number(string str)
        {
            var tmp = str;
            var result = "";
            while (str.Length > 0)
            {
                var value = str.Substring(0, 1);
                switch (str.Length)
                {
                    case 3:
                        if (int.Parse(str) != 0)
                        {
                            if (value != "0")
                            {
                                result = ConvertNumber(value) + "trăm ";
                            }
                            else
                            {
                                result = "không trăm ";
                            }
                        }
                        break;
                    case 2:
                        if (value != "0")
                        {
                            if (string.IsNullOrEmpty(result))
                            {
                                if (value == "1")
                                {
                                    result = "mười ";
                                }
                                else
                                {
                                    result = ConvertNumber(value) + "mươi ";
                                }
                            }
                            else if (value == "1")
                            {
                                result = result + "mười ";
                            }
                            else
                            {
                                result = result + ConvertNumber(value) + "mươi ";
                            }
                        }
                        break;
                    case 1:
                        switch (value)
                        {
                            case "5":
                                if (string.IsNullOrEmpty(result))
                                {
                                    //005 or 05
                                    if (tmp.Length == 3 | tmp.Length == 2)
                                    {
                                        result = "lẻ năm ";
                                        //5
                                    }
                                    else
                                    {
                                        result = ConvertNumber(value);
                                    }
                                    //125 or 25 or 105
                                }
                                else
                                {
                                    if (tmp.Substring(1, 1) == "0")
                                    {
                                        result = result + "lẻ năm ";
                                    }
                                    else
                                    {
                                        result = result + "lăm ";
                                    }
                                }
                                break;
                            case "1":
                                if (string.IsNullOrEmpty(result))
                                {
                                    //001 or 01
                                    if (tmp.Length == 3 | tmp.Length == 2)
                                    {
                                        result = "lẻ một ";
                                        //5
                                    }
                                    else
                                    {
                                        result = "một ";
                                    }
                                    //121 or 21 or 101
                                }
                                else
                                {
                                    //101  121
                                    switch (tmp.Length)
                                    {
                                        case 3:
                                            if (tmp.Substring(1, 1) == "0")
                                            {
                                                result = result + "lẻ một ";
                                            }
                                            else if (tmp.Substring(1, 1) == "1")
                                            {
                                                result = result + "một ";
                                            }
                                            else
                                            {
                                                result = result + "mốt ";
                                            }
                                            break;
                                        case 2:
                                            if (tmp.Substring(0, 1) == "0")
                                            {
                                                result = result + "lẻ một ";
                                            }
                                            else if (tmp.Substring(0, 1) == "1")
                                            {
                                                result = result + "một ";
                                            }
                                            else
                                            {
                                                result = result + "mốt ";
                                            }
                                            break;
                                    }
                                }
                                break;
                            default:
                                if (value != "0")
                                {
                                    //002
                                    if (string.IsNullOrEmpty(result))
                                    {
                                        //002 or 02
                                        if (tmp.Length == 3 | tmp.Length == 2)
                                        {
                                            result = "lẻ " + ConvertNumber(value);
                                            //2
                                        }
                                        else
                                        {
                                            result = ConvertNumber(value);
                                        }

                                        //123 or 23 or 103
                                    }
                                    else
                                    {
                                        if (tmp.Substring(1, 1) == "0")
                                        {
                                            result = result + "lẻ " + ConvertNumber(value);
                                        }
                                        else
                                        {
                                            result = result + ConvertNumber(value);
                                        }
                                    }
                                }
                                break;
                        }
                        break;
                }
                str = str.Remove(0, 1);
            }
            return result;
        }
        /// <summary>
        /// Chuyển 1 số thành chữ
        /// </summary>
        /// <param name="str">Nằm trong khoảng 0 - 9</param>
        /// <returns>Chữ của số cần chuyển</returns>
        static string ConvertNumber(string str)
        {
            switch (str)
            {
                case "0":
                    return "không ";
                case "1":
                    return "một ";
                case "2":
                    return "hai ";
                case "3":
                    return "ba ";
                case "4":
                    return "bốn ";
                case "5":
                    return "năm ";
                case "6":
                    return "sáu ";
                case "7":
                    return "bảy ";
                case "8":
                    return "tám ";
                case "9":
                    return "chín ";
            }
            return "";
        }
        /// <summary>
        /// Chuyển kiểu ngày sang dạng chuỗi 'ngay {0} thang {1} nam {2}'
        /// </summary>
        /// <param name="str"></param>
        /// <param name="Upper"></param>
        /// <returns></returns>
        public static string DateToText(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            var temp = str.Split(new string[] { "/", "-", "." }, StringSplitOptions.None);
            if (temp.Length == 3)
            {
                var strTemp = "Ngày {0} tháng {1} năm {2}";
                return string.Format(strTemp, temp[0], temp[1], temp[2]);
            }
            return "";
        }
        /// <summary>
        /// Xóa ký hiệu đánh dấu trong file word
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSymbolRecognize(this string str)
        {
            str = str.Replace("&lt;&lt;", "").Replace("&gt;&gt;", "");
            return str.Replace("<<", "").Replace(">>", "");
        }

        public static string FormatCurrency(this string str)
        {
            try
            {
                decimal tien = decimal.Parse(str);
                return string.Format("{0:#,0.########}", tien).Replace(",", ".");
            }
            catch
            {
                throw;
            }

        }

        public static bool IsLarger(this string dt1, string dt2)
        {
            var temp = dt1.Split(new string[] { "/" }, StringSplitOptions.None);
            //if (dt1.Year > dt2.Year)
            //    return true;
            //if (dt1.Year < dt2.Year)
            //    return false;
            //if (dt1.Month > dt2.Month)
            //    return true;
            //if (dt1.Month < dt2.Month)
            //    return false;
            //if (dt1.Day >= dt2.Day)
            //    return true;
            return false;
        }

        public static bool IsSmaller(this string dt1, string dt2)
        {
            var temp = dt1.Split(new string[] { "/" }, StringSplitOptions.None);
            //if (dt1.Year > dt2.Year)
            //    return false;
            //if (dt1.Year < dt2.Year)
            //    return true;
            //if (dt1.Month > dt2.Month)
            //    return false;
            //if (dt1.Month < dt2.Month)
            //    return true;
            //if (dt1.Day <= dt2.Day)
            //    return true;
            return false;
        }
    }
}
