namespace Weather_Forecasting_Application
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(66, 99);
            button1.Name = "button1";
            button1.Size = new Size(386, 105);
            button1.TabIndex = 0;
            button1.Text = "Weather";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(66, 223);
            button2.Name = "button2";
            button2.Size = new Size(386, 105);
            button2.TabIndex = 1;
            button2.Text = "Forecast";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.weather_forecast_1444038_1280;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(520, 412);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}