namespace Weather_Forecasting_Application
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            Des_label = new Label();
            Main_label = new Label();
            Hum_label = new Label();
            Wind_label = new Label();
            Press_label = new Label();
            Temp_label = new Label();
            Lon_label = new Label();
            Lat_label = new Label();
            Cou_label = new Label();
            City_label = new Label();
            DT_label = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            icon_label = new Label();
            label13 = new Label();
            label14 = new Label();
            la_textBox = new TextBox();
            lo_textBox = new TextBox();
            get_button = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "City Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 20;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Palatino Linotype", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(533, 12);
            button1.Name = "button1";
            button1.Size = new Size(250, 46);
            button1.TabIndex = 2;
            button1.Text = "Get Weather";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(Des_label);
            groupBox1.Controls.Add(Main_label);
            groupBox1.Controls.Add(Hum_label);
            groupBox1.Controls.Add(Wind_label);
            groupBox1.Controls.Add(Press_label);
            groupBox1.Controls.Add(Temp_label);
            groupBox1.Controls.Add(Lon_label);
            groupBox1.Controls.Add(Lat_label);
            groupBox1.Controls.Add(Cou_label);
            groupBox1.Controls.Add(City_label);
            groupBox1.Controls.Add(DT_label);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(14, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 753);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weather Info";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(642, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Des_label
            // 
            Des_label.BorderStyle = BorderStyle.Fixed3D;
            Des_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Des_label.ForeColor = Color.Blue;
            Des_label.Location = new Point(280, 685);
            Des_label.Name = "Des_label";
            Des_label.Size = new Size(287, 32);
            Des_label.TabIndex = 22;
            // 
            // Main_label
            // 
            Main_label.BorderStyle = BorderStyle.Fixed3D;
            Main_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Main_label.ForeColor = Color.Blue;
            Main_label.Location = new Point(280, 623);
            Main_label.Name = "Main_label";
            Main_label.Size = new Size(287, 32);
            Main_label.TabIndex = 21;
            // 
            // Hum_label
            // 
            Hum_label.BorderStyle = BorderStyle.Fixed3D;
            Hum_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Hum_label.ForeColor = Color.Blue;
            Hum_label.Location = new Point(280, 552);
            Hum_label.Name = "Hum_label";
            Hum_label.Size = new Size(287, 32);
            Hum_label.TabIndex = 20;
            // 
            // Wind_label
            // 
            Wind_label.BorderStyle = BorderStyle.Fixed3D;
            Wind_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Wind_label.ForeColor = Color.Blue;
            Wind_label.Location = new Point(280, 487);
            Wind_label.Name = "Wind_label";
            Wind_label.Size = new Size(287, 32);
            Wind_label.TabIndex = 19;
            // 
            // Press_label
            // 
            Press_label.BorderStyle = BorderStyle.Fixed3D;
            Press_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Press_label.ForeColor = Color.Blue;
            Press_label.Location = new Point(280, 421);
            Press_label.Name = "Press_label";
            Press_label.Size = new Size(287, 32);
            Press_label.TabIndex = 18;
            // 
            // Temp_label
            // 
            Temp_label.BorderStyle = BorderStyle.Fixed3D;
            Temp_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Temp_label.ForeColor = Color.Blue;
            Temp_label.Location = new Point(280, 362);
            Temp_label.Name = "Temp_label";
            Temp_label.Size = new Size(287, 32);
            Temp_label.TabIndex = 17;
            // 
            // Lon_label
            // 
            Lon_label.BorderStyle = BorderStyle.Fixed3D;
            Lon_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Lon_label.ForeColor = Color.Blue;
            Lon_label.Location = new Point(280, 240);
            Lon_label.Name = "Lon_label";
            Lon_label.Size = new Size(287, 32);
            Lon_label.TabIndex = 16;
            // 
            // Lat_label
            // 
            Lat_label.BorderStyle = BorderStyle.Fixed3D;
            Lat_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Lat_label.ForeColor = Color.Blue;
            Lat_label.Location = new Point(280, 185);
            Lat_label.Name = "Lat_label";
            Lat_label.Size = new Size(287, 32);
            Lat_label.TabIndex = 15;
            // 
            // Cou_label
            // 
            Cou_label.BorderStyle = BorderStyle.Fixed3D;
            Cou_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            Cou_label.ForeColor = Color.Blue;
            Cou_label.Location = new Point(280, 66);
            Cou_label.Name = "Cou_label";
            Cou_label.Size = new Size(287, 32);
            Cou_label.TabIndex = 14;
            // 
            // City_label
            // 
            City_label.BorderStyle = BorderStyle.Fixed3D;
            City_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            City_label.ForeColor = Color.Blue;
            City_label.Location = new Point(280, 125);
            City_label.Name = "City_label";
            City_label.Size = new Size(287, 32);
            City_label.TabIndex = 13;
            // 
            // DT_label
            // 
            DT_label.BorderStyle = BorderStyle.Fixed3D;
            DT_label.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold);
            DT_label.ForeColor = Color.Blue;
            DT_label.Location = new Point(280, 302);
            DT_label.Name = "DT_label";
            DT_label.Size = new Size(287, 32);
            DT_label.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label12.Location = new Point(85, 685);
            label12.Name = "label12";
            label12.Size = new Size(154, 32);
            label12.TabIndex = 11;
            label12.Text = "Description:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label11.Location = new Point(85, 623);
            label11.Name = "label11";
            label11.Size = new Size(181, 32);
            label11.TabIndex = 10;
            label11.Text = "Main Weather:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label10.Location = new Point(85, 552);
            label10.Name = "label10";
            label10.Size = new Size(125, 32);
            label10.TabIndex = 9;
            label10.Text = "Humidity:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label9.Location = new Point(85, 487);
            label9.Name = "label9";
            label9.Size = new Size(158, 32);
            label9.TabIndex = 8;
            label9.Text = "Wind Speed:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label8.Location = new Point(85, 421);
            label8.Name = "label8";
            label8.Size = new Size(123, 32);
            label8.TabIndex = 7;
            label8.Text = "Pressure:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label7.Location = new Point(85, 363);
            label7.Name = "label7";
            label7.Size = new Size(169, 32);
            label7.TabIndex = 6;
            label7.Text = "Temperature:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label6.Location = new Point(85, 302);
            label6.Name = "label6";
            label6.Size = new Size(190, 32);
            label6.TabIndex = 5;
            label6.Text = "Date and Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label5.Location = new Point(85, 240);
            label5.Name = "label5";
            label5.Size = new Size(137, 32);
            label5.TabIndex = 4;
            label5.Text = "Longitude:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label4.Location = new Point(85, 185);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 3;
            label4.Text = "Latitude:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label3.Location = new Point(85, 126);
            label3.Name = "label3";
            label3.Size = new Size(141, 32);
            label3.TabIndex = 2;
            label3.Text = "City Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Bold);
            label2.Location = new Point(85, 66);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 1;
            label2.Text = "Country:";
            // 
            // icon_label
            // 
            icon_label.Location = new Point(981, 372);
            icon_label.Name = "icon_label";
            icon_label.Size = new Size(182, 64);
            icon_label.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto", 9F);
            label13.Location = new Point(112, 79);
            label13.Name = "label13";
            label13.Size = new Size(108, 32);
            label13.TabIndex = 5;
            label13.Text = "Latitude:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 9F);
            label14.Location = new Point(112, 123);
            label14.Name = "label14";
            label14.Size = new Size(127, 32);
            label14.TabIndex = 6;
            label14.Text = "Longitude:";
            // 
            // la_textBox
            // 
            la_textBox.Location = new Point(259, 74);
            la_textBox.Name = "la_textBox";
            la_textBox.Size = new Size(292, 39);
            la_textBox.TabIndex = 7;
            // 
            // lo_textBox
            // 
            lo_textBox.Location = new Point(259, 121);
            lo_textBox.Name = "lo_textBox";
            lo_textBox.Size = new Size(292, 39);
            lo_textBox.TabIndex = 8;
            // 
            // get_button
            // 
            get_button.BackColor = Color.LightSeaGreen;
            get_button.FlatStyle = FlatStyle.Popup;
            get_button.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_button.Location = new Point(579, 82);
            get_button.Name = "get_button";
            get_button.Size = new Size(204, 70);
            get_button.TabIndex = 9;
            get_button.Text = "Get Weather";
            get_button.UseVisualStyleBackColor = false;
            get_button.Click += get_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(855, 923);
            Controls.Add(get_button);
            Controls.Add(lo_textBox);
            Controls.Add(la_textBox);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(icon_label);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather App";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label Des_label;
        private Label Main_label;
        private Label Hum_label;
        private Label Wind_label;
        private Label Press_label;
        private Label Temp_label;
        private Label Lon_label;
        private Label Lat_label;
        private Label Cou_label;
        private Label City_label;
        private Label DT_label;
        private Label icon_label;
        private Label label13;
        private Label label14;
        private TextBox la_textBox;
        private TextBox lo_textBox;
        private Button get_button;
    }
}
