using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiMH_BUS
    {
        public static List<LoaiMH_DTO> GetLoaiMH()
        {
            return LoaiMH_DAO.GetLoaiMH();
        }
    }
}
