using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DAO
{
    public class Account_DAO
    {
        public static List<Account_DTO> GetAccount()
        {
            string squery = "select * from mathang";
            using (SqlConnection conn = DataProvider.GetConnection())
            {
                DataTable dt = DataProvider.TruyVanLayDuLieu(squery, conn);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<Account_DTO> lstAccount = new List<Account_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Account_DTO account = new Account_DTO();
                    account.Hoten = dt.Rows[i]["hoten"].ToString();
                    account.Username = dt.Rows[i]["username"].ToString();
                    account.Password = dt.Rows[i]["password"].ToString();
                    account.Diachi = dt.Rows[i]["dongia"].ToString();
                    account.SDT = dt.Rows[i]["sdt"].ToString();
                    account.Loaitk = int.Parse(dt.Rows[i]["sdt"].ToString()); 
                    lstAccount.Add(account);
                }
                return lstAccount;
            }
        }

        public static bool insertAccount(Account_DTO account)
        {
            string squery = string.Format(@"insert into account values(N'{0}', '{1}','{2}',N'{3}','{4}', {5})", account.Hoten, account.Username, account.Password, account.Diachi, account.SDT, 0);
            using (SqlConnection conn = DataProvider.GetConnection())
            {
                bool kq = DataProvider.TruyVanKhongLayDuLieu(squery, conn);
                return kq;
            }
        }
        public static Account_DTO checkUsername(string un)
        {
            string squery = string.Format(@"select * from account where username='{0}'",un);
            using (SqlConnection conn = DataProvider.GetConnection())
            {
                DataTable dt = DataProvider.TruyVanLayDuLieu(squery, conn);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                Account_DTO acccount = new Account_DTO();
                acccount.Hoten = dt.Rows[0]["hoten"].ToString();
                acccount.Username = dt.Rows[0]["username"].ToString();
                acccount.Password = dt.Rows[0]["password"].ToString();
                acccount.Diachi = dt.Rows[0]["diachi"].ToString();
                acccount.SDT = dt.Rows[0]["sdt"].ToString();
                acccount.Loaitk = int.Parse(dt.Rows[0]["loaitk"].ToString());
                return acccount;
            }    
        }
        public static Account_DTO checkAccount(string taikhoan, string matkhau)
        {
            string squery = string.Format(@"select * from account where username='{0}' and password='{1}'", taikhoan, matkhau);
            using (SqlConnection conn = DataProvider.GetConnection())
            {
                DataTable dt = DataProvider.TruyVanLayDuLieu(squery, conn);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                Account_DTO acccount = new Account_DTO();
                acccount.Hoten = dt.Rows[0]["hoten"].ToString();
                acccount.Username = dt.Rows[0]["username"].ToString();
                acccount.Password = dt.Rows[0]["password"].ToString();
                acccount.Diachi = dt.Rows[0]["diachi"].ToString();
                acccount.SDT = dt.Rows[0]["sdt"].ToString();
                acccount.Loaitk = int.Parse(dt.Rows[0]["loaitk"].ToString());
                return acccount;
            }
        }
    }
}
