using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Account_BUS
    {
        public static bool insertAccount(Account_DTO account)
        {
            return Account_DAO.insertAccount(account);
        }
        public static Account_DTO checkUsername(string un)
        {
            return Account_DAO.checkUsername(un);
        }
        public static Account_DTO checkAccount(string taikhoan, string matkhau)
        {
            return Account_DAO.checkAccount(taikhoan, matkhau);
        }

        public static bool TestConnection(string serverName)
        {
            return DataProvider.TestConnection(serverName);
        }
    }
}
