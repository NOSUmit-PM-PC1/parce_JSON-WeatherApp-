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

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGetInfo_Click(object sender, EventArgs e)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + textBoxCity.Text + "&appid=4e48950e61aa189901c61ad99f57a27a&units=metric";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                textBoxServerInfo.Text = streamReader.ReadToEnd();
            }


            
        }
    }
}
