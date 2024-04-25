using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuVuc_BUS
    {
        public static List<KhuVuc_DTO> GetKhuVuc(int makv)
        {
            return KhuVuc_DAO.GetKhuVuc(makv);
        }
        public static bool checkDeleteKhuVuc(int makv)
        {
            return KhuVuc_DAO.checkDeleteKhuVuc(makv);
        }
    } 
}
