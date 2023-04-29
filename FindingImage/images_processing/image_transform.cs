using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingImage.images_processing
{
    internal class image_transform
    {
        public static Bitmap resize(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            Bitmap kal = cutting_image(bmp);

            Bitmap result = new Bitmap(kal.Width / 2, kal.Height / 2);
            var g = Graphics.FromImage(result);

            g.DrawImage(kal, 0, 0, kal.Width / 2, kal.Height / 2);

            return result;
        }

        //deleting unnecessary pixels
        public static Bitmap cutting_image(Bitmap image)
        {

            int offset_x = image.Width % 2;
            int offset_y = image.Height % 2;

            Bitmap resized_image = new Bitmap(image.Width - offset_x, image.Height - offset_y);

            for (int x = 0; x < image.Width - offset_x; x++)
            {
                for (int y = 0; y < image.Height - offset_y; y++)
                {
                    resized_image.SetPixel(x, y, image.GetPixel(x, y));
                }
            }

            return resized_image;
        }

        //get part of main image with size of mini
        public static Bitmap cutting_macro(Bitmap image, int x, int y, int wid, int heh)
        {
            Bitmap buf = new Bitmap(wid, heh);

            for (int i = 0; i < wid; i++)
            {
                for (int j = 0; j < heh; j++)
                {
                    buf.SetPixel(i, j, image.GetPixel(i + x, j + y));
                }
            }

            return buf;
        }
    }
}
