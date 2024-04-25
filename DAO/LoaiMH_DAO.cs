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
    public class LoaiMH_DAO
    {
        static SqlConnection con;
        public static List<LoaiMH_DTO> GetLoaiMH()
        {
            using (con = DataProvider.GetConnection())
            {
                string squery = "select * from loaimathang";
                DataTable dt = DataProvider.TruyVanLayDuLieu(squery, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<LoaiMH_DTO> lstLoaimh = new List<LoaiMH_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    LoaiMH_DTO lmh = new LoaiMH_DTO();
                    lmh.Maloaimh = dt.Rows[i]["maloaimh"].ToString();
                    lmh.Tenloaimh = dt.Rows[i]["tenloaimh"].ToString();
                    lstLoaimh.Add(lmh);
                }
                return lstLoaimh;
            }
        }
    }
}
