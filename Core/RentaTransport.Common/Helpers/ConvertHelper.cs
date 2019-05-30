using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace RentaTransport.Common.Helpers
{
    public static class ConvertHelper
    {
        public static byte[] ToBinary(IFormFile formFile)
        {
            using (var ms = new MemoryStream())
            {
                formFile.CopyTo(ms);
                var fileBytes = ms.ToArray();
                return fileBytes;
            }
        }

        public static byte[] ToBinary(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public static string ToBase64String(byte[] data)
        {
            var base64 = Convert.ToBase64String(data);
            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
            return imgSrc;
        }

        public static Bitmap ToBitmap(byte[] bmp)
        {
            if (bmp != null)
            {
                TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                Bitmap b = (Bitmap)tc.ConvertFrom(bmp);
                return b;
            }
            return null;
        }
    }
}
