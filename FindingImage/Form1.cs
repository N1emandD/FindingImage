using FindingImage.image_finding_process;
using FindingImage.images_processing;

namespace FindingImage
{
    public partial class Form1 : Form
    {
        Image find_image;
        Image main_image;

        Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Image files (*BMP; *JPG; *JPEG; *PNG;)|*BMP; *JPG; *JPEG; *PNG;|All files(*.*)|*.*";
        }
        private void finding_image_click_Click(object sender, EventArgs e)
        {
            //setting finding image
            find_image = image_checking.load_pic(find_image, find_image_status, openFileDialog1);

            //checking sizes of both images
            if (find_image_status.Text != "" && main_image_status.Text != "")
            {
                image_checking.sizes_verdict(find_image, main_image);
            }

        }

        private void main_image_click_Click(object sender, EventArgs e)
        {
            //setting main image
            main_image = image_checking.load_pic(main_image, main_image_status, openFileDialog1);

            //checking sizes of both images
            if (find_image_status.Text != "" && main_image_status.Text != "")
            {

                image_checking.sizes_verdict(find_image, main_image);

            }

        }

        private void finding_button_Click(object sender, EventArgs e)
        {

            final_count.Clear();

            Bitmap mini_bitmap;
            Bitmap macro_bitmap;

            //transform images to bitmap
            try
            {
                mini_bitmap = new Bitmap(find_image);
                macro_bitmap = new Bitmap(main_image);
            }

            catch
            {
                MessageBox.Show("Upload your pictures, please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = process_finding.main_cycle(mini_bitmap, macro_bitmap);
            final_count.Text = count.ToString();

            //new Bitmap(find_image);
            //image_transform.resize(find_image)
        }

        private void upload_button_Click(object sender, EventArgs e)
        {

            try
            {
                custom_values.Items.Add($"{setted_name.Text} - is {final_count.Text}");
                keyValuePairs.Add(setted_name.Text, setted_value.Text);
            }

            catch
            {
                MessageBox.Show("Could you put your data, please?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void get_value_Click(object sender, EventArgs e)
        {

            if (custom_values.Text == "")
            {
                MessageBox.Show("It would be wonderful, if you chose the value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] buf = custom_values.Text.Split(' ');

            final_value.Text = (int.Parse(buf[buf.Length - 1]) * int.Parse(keyValuePairs[buf[0]])).ToString();

        }
    }
}