using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> GetHoaDon()
        {
            return HoaDon_DAO.GetHoaDon();
        }

        public static HoaDon_DTO GetHoaDonTheoMa(int ma)
        {
            return HoaDon_DAO.GetHoaDonTheoMa(ma);
        }

        public static HoaDon_DTO GetHoaDonTheoBan(int ma)
        {
            return HoaDon_DAO.GetHoaDonTheoBan(ma);
        }

        public static bool GopHoaDon(int mahdDau, int mahdCuoi)
        {
            return HoaDon_DAO.GopHoaDon(mahdDau, mahdCuoi);
        }

        public static bool ChuyenBan(int mahd, int mabanDau, int mabanCuoi)
        {
            return HoaDon_DAO.ChuyenBan(mahd, mabanDau, mabanCuoi);
        }

        public static bool InsertHoaDon(int maban)
        {
            return HoaDon_DAO.InsertHoaDon(maban);
        }
        public static bool UpdateHoaDon(int mahd, float giam, float tongtt)
        {
            return HoaDon_DAO.UpdateHoaDon(mahd, giam, tongtt);
        }
        public static bool DeleteHoaDon(int mahd)
        {
            return HoaDon_DAO.DeleteHoaDon(mahd);
        }
    }
}
