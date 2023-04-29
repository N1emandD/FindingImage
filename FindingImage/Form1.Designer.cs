namespace FindingImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            finding_image_click = new Button();
            main_image_click = new Button();
            final_count = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            find_image_status = new Label();
            main_image_status = new Label();
            finding_button = new Button();
            custom_values = new ComboBox();
            name_text = new Label();
            setted_name = new TextBox();
            setted_value = new TextBox();
            value_text = new Label();
            upload_button = new Button();
            final_value = new TextBox();
            get_value = new Button();
            SuspendLayout();
            // 
            // finding_image_click
            // 
            finding_image_click.Location = new Point(12, 12);
            finding_image_click.Name = "finding_image_click";
            finding_image_click.Size = new Size(173, 52);
            finding_image_click.TabIndex = 0;
            finding_image_click.Text = "Put finding image";
            finding_image_click.UseVisualStyleBackColor = true;
            finding_image_click.Click += finding_image_click_Click;
            // 
            // main_image_click
            // 
            main_image_click.Location = new Point(12, 90);
            main_image_click.Name = "main_image_click";
            main_image_click.Size = new Size(173, 51);
            main_image_click.TabIndex = 1;
            main_image_click.Text = "Put main image";
            main_image_click.UseVisualStyleBackColor = true;
            main_image_click.Click += main_image_click_Click;
            // 
            // final_count
            // 
            final_count.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            final_count.Location = new Point(12, 172);
            final_count.Name = "final_count";
            final_count.Size = new Size(100, 33);
            final_count.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // find_image_status
            // 
            find_image_status.AutoSize = true;
            find_image_status.Location = new Point(12, 67);
            find_image_status.Name = "find_image_status";
            find_image_status.Size = new Size(0, 15);
            find_image_status.TabIndex = 3;
            // 
            // main_image_status
            // 
            main_image_status.AutoSize = true;
            main_image_status.Location = new Point(12, 144);
            main_image_status.Name = "main_image_status";
            main_image_status.Size = new Size(0, 15);
            main_image_status.TabIndex = 4;
            // 
            // finding_button
            // 
            finding_button.Location = new Point(118, 172);
            finding_button.Name = "finding_button";
            finding_button.Size = new Size(67, 33);
            finding_button.TabIndex = 5;
            finding_button.Text = "Find";
            finding_button.UseVisualStyleBackColor = true;
            finding_button.Click += finding_button_Click;
            // 
            // custom_values
            // 
            custom_values.DropDownStyle = ComboBoxStyle.DropDownList;
            custom_values.FormattingEnabled = true;
            custom_values.Location = new Point(217, 12);
            custom_values.Name = "custom_values";
            custom_values.Size = new Size(269, 23);
            custom_values.TabIndex = 6;
            // 
            // name_text
            // 
            name_text.AutoSize = true;
            name_text.Location = new Point(217, 97);
            name_text.Name = "name_text";
            name_text.Size = new Size(59, 15);
            name_text.TabIndex = 7;
            name_text.Text = "Set name:";
            // 
            // setted_name
            // 
            setted_name.Location = new Point(282, 94);
            setted_name.Name = "setted_name";
            setted_name.Size = new Size(204, 23);
            setted_name.TabIndex = 8;
            // 
            // setted_value
            // 
            setted_value.Location = new Point(282, 123);
            setted_value.Name = "setted_value";
            setted_value.Size = new Size(204, 23);
            setted_value.TabIndex = 9;
            // 
            // value_text
            // 
            value_text.AutoSize = true;
            value_text.Location = new Point(219, 126);
            value_text.Name = "value_text";
            value_text.Size = new Size(57, 15);
            value_text.TabIndex = 10;
            value_text.Text = "Set value:";
            // 
            // upload_button
            // 
            upload_button.Location = new Point(217, 172);
            upload_button.Name = "upload_button";
            upload_button.Size = new Size(75, 33);
            upload_button.TabIndex = 11;
            upload_button.Text = "Upload";
            upload_button.UseVisualStyleBackColor = true;
            upload_button.Click += upload_button_Click;
            // 
            // final_value
            // 
            final_value.Location = new Point(217, 41);
            final_value.Name = "final_value";
            final_value.Size = new Size(269, 23);
            final_value.TabIndex = 12;
            // 
            // get_value
            // 
            get_value.Location = new Point(412, 172);
            get_value.Name = "get_value";
            get_value.Size = new Size(75, 33);
            get_value.TabIndex = 13;
            get_value.Text = "Get value";
            get_value.UseVisualStyleBackColor = true;
            get_value.Click += get_value_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 217);
            Controls.Add(get_value);
            Controls.Add(final_value);
            Controls.Add(upload_button);
            Controls.Add(value_text);
            Controls.Add(setted_value);
            Controls.Add(setted_name);
            Controls.Add(name_text);
            Controls.Add(custom_values);
            Controls.Add(finding_button);
            Controls.Add(main_image_status);
            Controls.Add(find_image_status);
            Controls.Add(final_count);
            Controls.Add(main_image_click);
            Controls.Add(finding_image_click);
            Name = "Form1";
            Text = "Points Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button finding_image_click;
        private Button main_image_click;
        private TextBox final_count;
        private OpenFileDialog openFileDialog1;
        private Label find_image_status;
        private Label main_image_status;
        private Button finding_button;
        private ComboBox custom_values;
        private Label name_text;
        private TextBox setted_name;
        private TextBox setted_value;
        private Label value_text;
        private Button upload_button;
        private TextBox final_value;
        private Button get_value;
    }
}