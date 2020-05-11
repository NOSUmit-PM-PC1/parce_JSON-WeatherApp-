using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listBoxCities.DataSource = weathers;
            listBoxCities.DisplayMember = "Name";

            dataGridViewCities.DataSource = weathers;
            
        }

        BindingList<WeatherInfoData> weathers = new BindingList<WeatherInfoData>();

        
        private void buttonGetInfo_Click(object sender, EventArgs e)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + textBoxCity.Text + "&appid=4e48950e61aa189901c61ad99f57a27a&units=metric";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                textBoxServerInfo.Text = streamReader.ReadToEnd();
            }

            WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(textBoxServerInfo.Text);
            WeatherInfoData weatherInfoData = new WeatherInfoData(weatherInfo);
            weathers.Add(weatherInfoData);

           // labelTemp.Text = weatherInfo.Main.Temp.ToString();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeatherInfoData weatherInfo = (WeatherInfoData)listBoxCities.SelectedItem;
           // labelTemp.Text = weatherInfo.Main.Temp.ToString();
           // textBoxServerInfo.Text = weatherInfo.Name + " " + weatherInfo.Main.Temp + " " + weatherInfo.Main.Pressure;
        }
    }

    class TemperatureInfo
    {
        public float Temp { get; set; }
        public float Pressure { get; set; }

        public override string ToString()
        {
            return Temp + " " + Pressure;
        }
    }


    class WeatherInfo
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
    }


    class WeatherInfoData
    {
        private float Temp { get; set; }
        public string Name { get; set; }
        public float Pressure { get; set; }

        public WeatherInfoData (WeatherInfo w)
        {
            Temp = w.Main.Temp;
            Name = w.Name;
            Pressure = w.Main.Pressure;
        }

    }



}
