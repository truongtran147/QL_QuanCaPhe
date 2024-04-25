using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class HoaDon_DAO
    {
        static SqlConnection conn;
        public static List<HoaDon_DTO> GetHoaDon()
        {
            using (conn = DataProvider.GetConnection())
            {
                string query = "select * from hoadon";
                DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
                List<HoaDon_DTO> listHD = new List<HoaDon_DTO>();
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        HoaDon_DTO hd = new HoaDon_DTO();
                        hd.Mahd = int.Parse(dt.Rows[i]["mahd"].ToString());
                        hd.Username = dt.Rows[i]["username"].ToString();
                        hd.Maban = int.Parse(dt.Rows[i]["maban"].ToString());
                        hd.Giovao = (DateTime)dt.Rows[i]["giovao"];
                        hd.Giora = (DateTime)dt.Rows[i]["giora"];
                        hd.Giam = float.Parse(dt.Rows[i]["giam"].ToString());
                        hd.Tongtt = float.Parse(dt.Rows[i]["tongtt"].ToString());
                    }
                    return listHD;
                }
                return null;
            }
        }

        public static HoaDon_DTO GetHoaDonTheoMa(int ma)
        {
            using (conn = DataProvider.GetConnection())
            {
                string query = string.Format("select * from hoadon where mahd = {0} and tongtt > 0", ma);
                DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
                if (dt.Rows.Count !=0)
                {
                    HoaDon_DTO hd = new HoaDon_DTO();
                    hd.Mahd = int.Parse(dt.Rows[0]["mahd"].ToString());
                    hd.Username = dt.Rows[0]["username"].ToString();
                    hd.Maban = int.Parse(dt.Rows[0]["maban"].ToString());
                    hd.Giovao = (DateTime)dt.Rows[0]["giovao"];
                    hd.Giora = (DateTime)dt.Rows[0]["giora"];
                    hd.Giam = float.Parse(dt.Rows[0]["giam"].ToString());
                    hd.Tongtt = float.Parse(dt.Rows[0]["tongtt"].ToString());
                    return hd;
                }
                return null;
            }
        }

        public static HoaDon_DTO GetHoaDonTheoBan(int maban)
        {
            using (conn = DataProvider.GetConnection())
            {
                string query = string.Format("select top 1 * from hoadon where maban = {0} ORDER BY mahd DESC", maban);
                DataTable dt = DataProvider.TruyVanLayDuLieu(query, conn);
                if (dt.Rows.Count !=0)
                {
                    HoaDon_DTO hd = new HoaDon_DTO();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        hd.Mahd = int.Parse(dt.Rows[0]["mahd"].ToString());
                        hd.Username = dt.Rows[0]["username"].ToString();
                        hd.Maban = int.Parse(dt.Rows[0]["maban"].ToString());
                        hd.Giovao = (DateTime)dt.Rows[0]["giovao"];
                        hd.Giora = DateTime.Now;
                        hd.Giam = float.Parse(dt.Rows[i]["giam"].ToString());
                        hd.Tongtt = float.Parse(dt.Rows[0]["tongtt"].ToString());
                    }
                    return hd;
                }
                return null;
            }
        }

        public static bool GopHoaDon(int mahdDau, int mahdCuoi)
        {
            try
            {
                string query = $"EXECUTE GopHoaDon @MahdDau = {mahdDau}, @MahdCuoi = {mahdCuoi};";
                conn = DataProvider.GetConnection();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message);
                return false;
            }
        }
        public static bool ChuyenBan(int mahd, int mabanDau, int mabanCuoi)
        {
            try
            {
                string query = $"EXECUTE ChuyenBan @Mahd = {mahd}, @MaBanDau = {mabanDau}, @MaBanCuoi = {mabanCuoi};";
                conn = DataProvider.GetConnection();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message);
                return false;
            }
        }


        public static bool InsertHoaDon(int maban)
        {
            try
            {
                //string query = string.Format(@"insert into hoadon (mahd, username, maban) values({ 0},'{ 1}',{ 2})", hd.Mahd, hd.Username, hd.Maban);
                string query = $"insert into hoadon (username, maban, giam, tongtt) values('thungan1',{maban}, 0, 0)";
                conn = DataProvider.GetConnection();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
                return kq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateHoaDon(int mahd, float giam, float tongtt)
        {
            string query = $"update hoadon set giora = GETDATE(), giam = {giam}, tongtt = {tongtt} where mahd = {mahd}";
            conn = DataProvider.GetConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
        public static bool DeleteHoaDon(int mahd)
        {
            string query = $"delete chitiethd where mahd = {mahd}; delete hoadon where mahd = {mahd} ";
            conn = DataProvider.GetConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
            return kq;
        }
    }
}
