using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Ban_DAO
    {
        static SqlConnection conn;
        public static List<Ban_DTO> GetBan(int ma)
        {
            string squery;
            if (ma == -1)
                squery = "select * from ban";
            else
                squery = "select * from ban where makv = " + ma + "";
            conn = DataProvider.GetConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(squery, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Ban_DTO> lstBan = new List<Ban_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Ban_DTO ban = new Ban_DTO();
                ban.Maban = int.Parse(dt.Rows[i]["maban"].ToString());
                ban.Tenban = dt.Rows[i]["tenban"].ToString();
                ban.Makv = int.Parse(dt.Rows[i]["makv"].ToString());
                ban.Trangthai = dt.Rows[i]["trangthai"].ToString();
                lstBan.Add(ban);
            }
            return lstBan;
        }

        public static bool UpdateBan(Ban_DTO ban)
        {
            try
            {
                string query = $"update ban set tenban = '{ban.Tenban}', makv = {ban.Makv}, trangthai = N'{ban.Trangthai}' where maban = {ban.Maban}";
                conn = DataProvider.GetConnection();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(query, conn);
                return kq;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
