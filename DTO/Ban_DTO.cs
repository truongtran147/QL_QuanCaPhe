using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        private int maban;
        public int Maban
        {
            get { return maban; }
            set { maban = value; }
        }
        private string tenban;

        public string Tenban
        {
            get { return tenban; }
            set { tenban = value; }
        }

        private int makv;

        public int Makv
        {
            get { return makv; }
            set { makv = value; }
        }
        private string trangthai;
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
