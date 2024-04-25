using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang_DTO
    {
        private int mamh;
        public int MaMH
        {
            get { return mamh; }
            set { mamh = value; }
        }
        private string tenmh;
        public string TenMH
        {
            get { return tenmh; }
            set { tenmh = value; }
        }
        private string maloaimh;
        public string MaloaiMH
        {
            get { return maloaimh; }
            set { maloaimh = value; }
        }
        private float dongia;
        public float DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private byte[] anhmh;
        public byte[] Anhmh
        {
            get { return anhmh; }
            set { anhmh = value; }
        }

        //ảnh -> byte[]
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


    }
}
