using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHD_DAO
    {
        static SqlConnection conn;
        static string query;
        public static List<ChiTietHD_DTO> GetCTHD(int ma)
        {
            using (conn = DataProvider.GetConnection())
            {
                query = "SELECT chitiethd.*, mathang.tenmh FROM chitiethd INNER JOIN mathang ON chitiethd.mamh = mathang.mamh WHERE mahd = " + ma;
                DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
                if (dt.Rows.Count != 0)
                {
                    List<ChiTietHD_DTO> listCTHD = new List<ChiTietHD_DTO>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ChiTietHD_DTO cthd = new ChiTietHD_DTO();
                        cthd.Mahd = int.Parse(dt.Rows[i]["mahd"].ToString());
                        cthd.Mamh = int.Parse(dt.Rows[i]["mamh"].ToString());
                        cthd.Dongia = float.Parse(dt.Rows[i]["dongia"].ToString());
                        cthd.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                        cthd.Thanhtien = float.Parse(dt.Rows[i]["thanhtien"].ToString());
                        cthd.Tenmh = dt.Rows[i]["tenmh"].ToString();
                        listCTHD.Add(cthd);
                    }
                    return listCTHD;
                }
                return null;
            }    
        }

        public static bool DaTonTai(int mahd, int mamh)
        {
            using (conn = DataProvider.GetConnection())
            {
                query = string.Format("SELECT * FROM chitiethd WHERE mahd = {0} AND mamh = {1}", mahd, mamh);
                DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
                if (dt.Rows.Count > 0)
                {
                    query = string.Format("UPDATE chitiethd SET soluong = soluong + 1, thanhtien = soluong * dongia WHERE mahd = {0} AND mamh = {1}", mahd, mamh);
                    DataProvider.TruyVanKhongLayDuLieu(query,conn);
                    return true;
                }
                return false;
            }
        }
        
        public static bool InsertCTHD(ChiTietHD_DTO cthd)
        {
            using (conn = DataProvider.GetConnection())
            {
                query = string.Format("insert into chitiethd values ({0}, {1}, {2}, {3}, {4})", cthd.Mahd, cthd.Mamh, cthd.Dongia, cthd.Soluong, cthd.Thanhtien);
                return DataProvider.TruyVanKhongLayDuLieu(query, conn);
            }
        }

        public static bool UpdateCTHD(ChiTietHD_DTO cthd)
        {
            using (conn = DataProvider.GetConnection())
            {
                query = string.Format("update chitiethd set dongia = {0}, soluong = {1}, thanhtien = {2} where mahd = '{3}' and mamh = '{4}'",cthd.Dongia, cthd.Soluong, cthd.Thanhtien, cthd.Mahd, cthd.Mamh);
                return DataProvider.TruyVanKhongLayDuLieu(query, conn);
            }    
        }

        public static bool DeleteCTHD(ChiTietHD_DTO cthd)
        {
            using (conn = DataProvider.GetConnection())
            {
                query = string.Format("delete chitiethd where mahd = '{0}' and mamh = '{1}'", cthd.Mahd, cthd.Mamh);
                return DataProvider.TruyVanKhongLayDuLieu(query, conn);
            }
        }
    }
}
