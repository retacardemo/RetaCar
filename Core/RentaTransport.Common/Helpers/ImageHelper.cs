using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace RentaTransport.Common.Helpers
{
    public static class ImageHelper
    {
        public static byte[] Resize(IFormFile image, int width, int height, string text = "Devs\\Az")
        {
            //convert from iformfile to binary
            var binaryImage = ConvertHelper.ToBinary(image);
            //convert from binary to bitmap
            var bitmap = ConvertHelper.ToBitmap(binaryImage);
            // To void the error due to Indexed Pixel Format
            Image img = new Bitmap(bitmap, new Size(width, height));
            Bitmap tmp = new Bitmap(img);
            Graphics graphic = Graphics.FromImage(tmp);
            // Watermark effect
            //SolidBrush brush = new SolidBrush(System.Drawing.Color.Transparent);
            // Draw the text string to the Graphics object at a given position.
            //graphic.DrawString(text, new Font("Times New Roman", 14, FontStyle.Italic), brush, new PointF(10, 30));
            graphic.CompositingMode = CompositingMode.SourceCopy;
            graphic.CompositingQuality = CompositingQuality.HighQuality;
            graphic.Dispose();
            return ConvertHelper.ToBinary(tmp);
        }
    }
}
