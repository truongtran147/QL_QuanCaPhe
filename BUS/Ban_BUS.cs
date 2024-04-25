using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Ban_BUS
    {
        public static List<Ban_DTO> GetBan(int ma)
        {
            return Ban_DAO.GetBan(ma);
        }
        public static bool UpdateBan(Ban_DTO ban)
        {
            return Ban_DAO.UpdateBan(ban);
        }
    }
}
