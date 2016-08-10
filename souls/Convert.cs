using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souls
{
    public class Convert
    {
        public static byte[] ConvertImagetoByte(Image img)
        {
            if (img == null) return null;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            byte[] bytes = ms.ToArray();
            ms.Close();
            return bytes;
        }

        public static Image ConvertBytetoImage(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
