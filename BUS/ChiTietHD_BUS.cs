using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHD_BUS
    {
        public static List<ChiTietHD_DTO> GetCTHD(int ma)
        {
            return ChiTietHD_DAO.GetCTHD(ma);
        }
        public static bool InsertCTHD(ChiTietHD_DTO cthd)
        {
            return ChiTietHD_DAO.InsertCTHD(cthd);
        }

        public static bool UpdateCTHD(ChiTietHD_DTO cthd)
        {
            return ChiTietHD_DAO.UpdateCTHD(cthd);
        }

        public static bool DeleteCTHD(ChiTietHD_DTO cthd)
        {
            return ChiTietHD_DAO.DeleteCTHD(cthd);
        }
        public static bool DaTonTai(int mahd, int mamh)
        {
            return ChiTietHD_DAO.DaTonTai(mahd, mamh);
        }    
    }
}
