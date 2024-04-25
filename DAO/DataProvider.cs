using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace DAO
{
    public class DataProvider
    {
        public static bool TestConnection(string serverName)
        {
            string mainConnectionString = $"Data Source={serverName};Initial Catalog=QLQuanCaPhe;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(mainConnectionString))
                {
                    connection.Open();
                    return true; // Kết nối thành công
                }
            }
            catch (SqlException)
            {
                return false; // Kết nối không thành công
            }
        }
        
        public static SqlConnection GetConnection()
        {
            string s = @"Data Source=laptop-3otuqj91\truongsql;Initial Catalog=QLQuanCaPhe;Integrated Security=True;";
            SqlConnection KetNoi = new SqlConnection(s);
            KetNoi.Open();
            return KetNoi;
        }
        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
