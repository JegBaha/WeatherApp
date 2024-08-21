using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace StajWeatherProje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            timeLabel.Text = DateTime.Now.ToShortTimeString();
            
            datelabel.Text = DateTime.Now.ToLongDateString();
            string apiKey = "c2f46be276b974ef550e5a0d518de86e";
            string conThing = "https://api.openweathermap.org/data/2.5/weather?q=k%C4%B1rklareli&mode=xml&lang=tr&units=metric&appid=" + apiKey;
            XDocument weather=XDocument.Load(conThing);
            var tempDeg = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var weatherType = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var humidity= weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            Console.Write(tempDeg);
            Console.ReadLine();
           
            firstDeg.Text = tempDeg+" C";
            if (weatherType == "açık")
            {
                Hava1.Visible = false;
                Açık1.Visible = true;
            }
            if (weatherType == "bulutlu")
            {
                Hava1.Visible = false;
                bulutlu1.Visible = true;
            }
            if (weatherType == "yağmurlu")
            {
                Hava1.Visible = false;
                yağmurlu1.Visible = true;
            }


            Gün1.Text = DateTime.Now.ToLongDateString();
            Gün2.Text=DateTime.Now.AddDays(1).ToLongDateString();
            Gün3.Text=DateTime.Now.AddDays(2).ToLongDateString();
            Gün4.Text = DateTime.Now.AddDays(3).ToLongDateString();
         

        }
            private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           timeLabel.Text=DateTime.Now.ToShortTimeString();
            datelabel.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LocationLabel.Text = locationText.Text;
        }
    }
}
