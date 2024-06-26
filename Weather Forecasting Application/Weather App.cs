using static System.Net.WebRequestMethods;

namespace Weather_Forecasting_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter the City Name");
                    return;
                }

                string url, city_name;
                System.Net.WebClient wcl = new System.Net.WebClient();
                string json_text;
                //----------------
                city_name = this.textBox1.Text;
                url = "https://api.openweathermap.org/data/2.5/weather?q=" + city_name + "&units=metric" + "&appid=78670ff3a19be0b97dcbf820bef46c55";
                //----------------
                json_text = wcl.DownloadString(url);
                //----------------
                Newtonsoft.Json.Linq.JObject json = new Newtonsoft.Json.Linq.JObject();
                //Newtonsoft.Json.Linq.JToken json_token;
                json = Newtonsoft.Json.Linq.JObject.Parse(json_text);
                //---------------------------                
                weather_loader(json["coord"]["lon"], this.Lon_label, "");
                //---------------------------                
                weather_loader(json["coord"]["lat"], this.Lat_label, "");
                //---------------------------                
                weather_loader(json["main"]["pressure"], this.Press_label, " hPa");
                //---------------------------                
                weather_loader(json["main"]["humidity"], this.Hum_label, "%");
                //---------------------------                
                weather_loader(json["main"]["temp"], this.Temp_label, " °C");
                //---------------------------                
                weather_loader(json["sys"]["country"], this.Cou_label, "");
                //---------------------------                
                weather_loader(json["name"], this.City_label, "");
                //---------------------------                
                weather_loader(json["wind"]["speed"], this.Wind_label, "");
                //---------------------------                    
                weather_loader(json["weather"][0]["main"], this.Main_label, "");
                //---------------------------                
                weather_loader(json["weather"][0]["description"], this.Des_label, "");
                //-------------------------------------
                this.DT_label.Text = System.DateTime.Now.ToString();
                //------------------------------------
                //http://openweathermap.org/img/w/04d.png
                weather_loader(json["weather"][0]["icon"], this.icon_label, "");
                string icon_txt;
                icon_txt = "http://openweathermap.org/img/w/" + this.icon_label.Text + ".png";
                this.pictureBox1.Load(icon_txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("City not found " + "\n" + ex.Message);
            }
        }
        void weather_loader(Newtonsoft.Json.Linq.JToken json_token, Label lbl_info, string unit)
        {
            if (json_token != null)
            {
                lbl_info.Text = json_token.ToString() + unit;
            }
        }

        private void get_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.la_textBox.Text == ""|| this.lo_textBox.Text=="")
                {
                    MessageBox.Show("Please Enter the City Name");
                    return;
                }

                string url, lat, lon;
                System.Net.WebClient wcl = new System.Net.WebClient();
                string json_text;
                //----------------
                lat = this.la_textBox.Text;
                lon = this.lo_textBox.Text;
                url = "https://api.openweathermap.org/data/2.5/weather?lat=" + lat +"&lon="+lon+ "&units=metric" + "&appid=78670ff3a19be0b97dcbf820bef46c55";
                //----------------
                json_text = wcl.DownloadString(url);
                //----------------
                Newtonsoft.Json.Linq.JObject json = new Newtonsoft.Json.Linq.JObject();
                //Newtonsoft.Json.Linq.JToken json_token;
                json = Newtonsoft.Json.Linq.JObject.Parse(json_text);
                //---------------------------                
                weather_loader(json["coord"]["lon"], this.Lon_label, "");
                //---------------------------                
                weather_loader(json["coord"]["lat"], this.Lat_label, "");
                //---------------------------                
                weather_loader(json["main"]["pressure"], this.Press_label, " hPa");
                //---------------------------                
                weather_loader(json["main"]["humidity"], this.Hum_label, "%");
                //---------------------------                
                weather_loader(json["main"]["temp"], this.Temp_label, " °C");
                //---------------------------                
                weather_loader(json["sys"]["country"], this.Cou_label, "");
                //---------------------------                
                weather_loader(json["name"], this.City_label, "");
                //---------------------------                
                weather_loader(json["wind"]["speed"], this.Wind_label, "");
                //---------------------------                    
                weather_loader(json["weather"][0]["main"], this.Main_label, "");
                //---------------------------                
                weather_loader(json["weather"][0]["description"], this.Des_label, "");
                //-------------------------------------
                this.DT_label.Text = System.DateTime.Now.ToString();
                //------------------------------------
                //http://openweathermap.org/img/w/04d.png
                weather_loader(json["weather"][0]["icon"], this.icon_label, "");
                string icon_txt;
                icon_txt = "http://openweathermap.org/img/w/" + this.icon_label.Text + ".png";
                this.pictureBox1.Load(icon_txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("City not found " + "\n" + ex.Message);
            }
        }
    }
}
