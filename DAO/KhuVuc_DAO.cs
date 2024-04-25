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
    public class KhuVuc_DAO
    {
        static SqlConnection con;
        static string query;
        public static List<KhuVuc_DTO> GetKhuVuc(int makv)
        {
            using (con = DataProvider.GetConnection())
            {
                if (makv == -1)
                    query = "select * from khuvuc";
                else
                    query = "select * from khuvuc where makv = "+makv;
                DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<KhuVuc_DTO> listKhuVuc = new List<KhuVuc_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KhuVuc_DTO kv = new KhuVuc_DTO();
                    kv.Makv = int.Parse(dt.Rows[i]["makv"].ToString());
                    kv.Tenkv = dt.Rows[i]["tenkv"].ToString();
                    listKhuVuc.Add(kv);
                }
                return listKhuVuc;
            }
        }
        public static bool checkDeleteKhuVuc(int makv)
        {
            query = "SELECT COUNT(*) FROM ban WHERE makv = " + makv;
            int kq = 0;
            using (con = DataProvider.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    kq = (int)command.ExecuteScalar();
                }
            }
            return kq == 0;
        }

    }
}
