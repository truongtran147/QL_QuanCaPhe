using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using DTO;
using DAO;

namespace BUS
{
    public class MatHang_BUS
    {
        public static List<MatHang_DTO> GetMatHang(string ma)
        {
            return MatHang_DAO.GetMatHang(ma);
        }
    }
}
