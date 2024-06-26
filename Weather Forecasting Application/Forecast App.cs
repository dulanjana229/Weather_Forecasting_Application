using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Forecasting_Application
{
    public partial class Forecast_App : Form
    {
        public Forecast_App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the City Name");
                return;
            }
            //--------------------
            this.panel2.Visible = true;
            this.panel2.Refresh();
            //--------------------

            string url, city_name;
            System.Net.WebClient wcl = new System.Net.WebClient();
            string json_text = "";
            //----------------
            city_name = this.textBox1.Text;
            url = "https://api.openweathermap.org/data/2.5/forecast?q=" + city_name + "&units=metric" + "&cnt=" + this.numericUpDown1.Value.ToString() + "&appid=78670ff3a19be0b97dcbf820bef46c55";
            //----------------

            try
            {
                json_text = wcl.DownloadString(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("City not found!" + "\n" + ex.Message);
                //--------------------
                this.panel2.Visible = false;
                //--------------------
                return;
            }
            //------------
            data_loader(json_text);            
            //--------------------
            this.panel2.Visible = false;
            //--------------------
        }

        private void get_button_Click(object sender, EventArgs e)
        {

            if (this.la_textBox.Text == "" || this.lo_textBox.Text == "")
            {
                MessageBox.Show("Please Enter the City Name");
                return;
            }
            //--------------------
            this.panel2.Visible = true;
            this.panel2.Refresh();
            //--------------------
            string url, lat, lon;
            System.Net.WebClient wcl = new System.Net.WebClient();
            string json_text;
            //----------------
            lat = this.la_textBox.Text;
            lon = this.lo_textBox.Text;
            url = "https://api.openweathermap.org/data/2.5/forecast?lat=" + lat + "&lon=" + lon + "&units=metric" + "&cnt=" + this.numericUpDown2.Value.ToString() + "&appid=78670ff3a19be0b97dcbf820bef46c55";
            //----------------
            try
            {
                json_text = wcl.DownloadString(url);
            }
            catch (Exception ex)
            {

                MessageBox.Show("City not found!" + "\n" + ex.Message);
                //--------------------
                this.panel2.Visible = false;
                //--------------------
                return;
            }
            //---------------
            data_loader(json_text);
            //--------------------
            this.panel2.Visible = false;
            //--------------------

        }
        void weather_loader(Newtonsoft.Json.Linq.JToken json_token, Label lbl_info, string unit)
        {
            if (json_token != null)
            {
                lbl_info.Text = json_token.ToString() + unit;
            }
        }
        void data_loader(string json_text)
        {

            Newtonsoft.Json.Linq.JObject json = new Newtonsoft.Json.Linq.JObject();
            //Newtonsoft.Json.Linq.JToken json_token;
            json = Newtonsoft.Json.Linq.JObject.Parse(json_text);
            //---------------------------                
            weather_loader(json["cnt"], this.cnt_label, "");
            //---------------------------

            this.dataGridView1.Rows.Clear();
            //---------------------------

            int cnt = 1;
            cnt = int.Parse(this.cnt_label.Text);
            for (int i = 0; i < cnt; i++)
            {
                //---------------------------            
                weather_loader(json["city"]["coord"]["lon"], this.Lon_label, "");
                //---------------------------                
                weather_loader(json["city"]["coord"]["lat"], this.Lat_label, "");
                //---------------------------                
                weather_loader(json["list"][i]["main"]["pressure"], this.Press_label, " hPa");
                //---------------------------                
                weather_loader(json["list"][i]["main"]["humidity"], this.Hum_label, "%");
                //---------------------------                
                weather_loader(json["list"][i]["main"]["temp"], this.Temp_label, " °C");
                //---------------------------                
                weather_loader(json["city"]["country"], this.Cou_label, "");
                //---------------------------                
                weather_loader(json["city"]["name"], this.City_label, "");
                //---------------------------                
                weather_loader(json["list"][i]["wind"]["speed"], this.Wind_label, "");
                //---------------------------                    
                weather_loader(json["list"][i]["weather"][0]["main"], this.Main_label, "");
                //---------------------------                
                weather_loader(json["list"][i]["weather"][0]["description"], this.Des_label, "");
                //-------------------------------------
                weather_loader(json["list"][i]["dt_txt"], this.DT_label, "");
                //------------------------------------
                //http://openweathermap.org/img/w/04d.png
                weather_loader(json["list"][i]["weather"][0]["icon"], this.icon_label, "");
                string icon_txt;
                icon_txt = "http://openweathermap.org/img/w/" + this.icon_label.Text + ".png";
                this.pictureBox1.Load(icon_txt);
                //-----------------------------
                this.dataGridView1.Rows.Add(this.pictureBox1.Image, this.DT_label.Text, this.Main_label.Text, this.Des_label.Text, this.Temp_label.Text, this.Hum_label.Text, this.Press_label.Text, this.Cou_label.Text,
                    this.City_label.Text, this.Lon_label.Text, this.Lat_label.Text);
            }


        }
    }
}
