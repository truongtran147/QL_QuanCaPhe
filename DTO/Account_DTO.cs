using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_DTO
    {
        private string hoten;
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string diachi;
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private int loaitk;
        public int Loaitk
        {
            get { return loaitk; }
            set { loaitk = value; }
        }
    }
}
