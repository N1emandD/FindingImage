namespace FindingImage.images_processing
{
    public class image_checking
    {
        public static Image load_pic(Image image, Label label, OpenFileDialog openFileDialog1)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(openFileDialog1.FileName);
                    label.Text = $"{openFileDialog1.FileName} loaded";
                }
            }
            catch
            {
                MessageBox.Show("Man, something went wrong, please try put correct image", "Error put", MessageBoxButtons.OK);
            }
            return image;
        }

        public static bool check_sizes(Image mini_image, Image macro_image)
        {

            if (macro_image.Height > mini_image.Height && macro_image.Width > mini_image.Width)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void sizes_verdict(Image mini_image, Image macro_image)
        {
            if (!check_sizes(mini_image, macro_image))
            {
                MessageBox.Show("Finding image can't be contained in the main image, next time choose correct pics!", "Error", MessageBoxButtons.OK);
                return;
            }
        }
        
    }
}
