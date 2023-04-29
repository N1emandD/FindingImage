using FindingImage.images_processing;
using System.Diagnostics;

namespace FindingImage.image_finding_process
{
    internal class process_finding
    {
        
        public static int count;
        // checking cycle for image | my english suck some dicks
        public static int main_cycle (Bitmap mini, Bitmap macro)
        {
            for (int heh = 0; heh < macro.Height; heh++)
            {
                if (heh >= macro.Height - mini.Height - 1)
                {
                    break;
                }

                for (int wid = 0; wid < macro.Width; wid++)
                {
                    if (wid >= macro.Width - mini.Width - 1)
                    {
                        break;
                    }

                    if (mini_checking(mini, macro, heh, wid) == true)
                    {
                        count += 1;
                    }
                    
                }
            }

            return count;
        }

        //checking finding bitmap borders and "cross"
        public static bool mini_checking (Bitmap mini, Bitmap mini_from_macro, int j, int i)
        {

            //Bitmap buf = image_transform.cutting_macro(mini_from_macro, i, j, mini.Width, mini.Height);

            int middle_y = mini.Height / 2;
            int middle_x = mini.Width / 2;

            //multiplicated height and width

            for (int x = 0; x < mini.Width; x++)
            {
                
                if (mini.GetPixel(x, middle_y) != mini_from_macro.GetPixel(i + x, j + middle_y))
                {
                    return false;
                }

            }

            for (int x = middle_x / 2; x < (3 * middle_x) / 2; x++)
            {

                if (mini.GetPixel(x, middle_y / 2) != mini_from_macro.GetPixel(i + x, j + middle_y / 2))
                {
                    return false;
                }

                if (mini.GetPixel(x, (3* middle_y / 2)) != mini_from_macro.GetPixel(i + x, j + (3 * middle_y / 2)))
                {
                    return false;
                }
            }

            for (int y = 0; y < mini.Height; y++)
            {
                
                if (mini.GetPixel(middle_x, y) != mini_from_macro.GetPixel(i + middle_x, j + y))
                {
                    return false;
                }
            }

            for (int y = middle_y / 2; y < (3 * middle_y) / 2; y++)
            {

                if (mini.GetPixel(middle_x / 2, y) != mini_from_macro.GetPixel(i + middle_x / 2, j + y))
                {
                    return false;
                }

                if (mini.GetPixel((3 * middle_x / 2), y) != mini_from_macro.GetPixel(i + (3 * middle_x / 2), j + y))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
