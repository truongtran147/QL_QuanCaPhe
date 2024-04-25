using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;

namespace DAO
{
    public class MatHang_DAO
    {
        static SqlConnection con;
        public static List<MatHang_DTO> GetMatHang(string ma)
        {
            string squery;
            if (ma == "" || ma == null)
                squery = "select * from mathang ORDER BY maloaimh ASC";
            else
                squery = "select * from mathang where maloaimh = '" + ma + "' ORDER BY maloaimh ASC";
            con = DataProvider.GetConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(squery, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MatHang_DTO> lstMatHang = new List<MatHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MatHang_DTO mh = new MatHang_DTO();
                mh.MaMH = int.Parse(dt.Rows[i]["mamh"].ToString());
                mh.TenMH = dt.Rows[i]["tenmh"].ToString();
                mh.MaloaiMH = dt.Rows[i]["maloaimh"].ToString();
                mh.DonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                System.Drawing.Image item = Properties.Resources.sampleItem;
                if (dt.Rows[i]["anhmh"].ToString() == string.Empty)
                    mh.Anhmh = imageToByteArray(item);
                else
                    mh.Anhmh = (byte[])dt.Rows[i]["anhmh"];
                lstMatHang.Add(mh);
            }
            return lstMatHang;
        }

        private static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }

    }
}
