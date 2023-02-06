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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HavaDurumuApiCekme
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
        public void havaDurumuAl(string sehirr)
        {
            string api = "231a1d38680883db83264b3d4c06178b";
            string bağlantı = $"https://api.openweathermap.org/data/2.5/weather?q={sehirr}&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load("https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api);
            bool kontrol = true;
            try
            {
                hava = XDocument.Load(bağlantı);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bir Şehir İsmi Giriniz");
                kontrol = false;
            }



            var hissedilensicaklik = hava.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgarhizi = hava.Descendants("speed").ElementAt(0).Attribute("value").Value + hava.Descendants("speed").ElementAt(0).Attribute("unit").Value;
            var havadurumu = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            string sehir = hava.Descendants("city").ElementAt(0).Attribute("name").Value;
            var gundogumu = hava.Descendants("sun").ElementAt(0).Attribute("rise").Value;
            var gunbatimi = hava.Descendants("sun").ElementAt(0).Attribute("set").Value;
            var bulutdurumu = hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("unit").Value + hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var basinc = hava.Descendants("pressure").ElementAt(0).Attribute("value").Value + hava.Descendants("pressure").ElementAt(0).Attribute("unit").Value;

            gundogumu = gundogumu.Substring(11, 8);
            gunbatimi = gunbatimi.Substring(11, 8);


            int artirilankisim = Convert.ToInt32(gundogumu.Substring(0, 2));
            if (artirilankisim < 21)
            {

                string[] timeParts = gundogumu.Split(':');
                int hour = Convert.ToInt32(timeParts[0]);
                hour += 3;
                gundogumu = hour.ToString() + ":" + timeParts[1] + ":" + timeParts[2];
            }
            else
            {
                switch (artirilankisim)
                {
                    case 21:
                        gundogumu.Replace("21", "0");
                        break;
                    case 22:
                        gundogumu.Replace("22", "1");
                        break;
                    case 23:
                        gundogumu.Replace("23", "2");
                        break;
                    case 24:
                        gundogumu.Replace("24", "3");
                        break;
                    default:
                        break;
                }
            }
            artirilankisim = Convert.ToInt32(gunbatimi.Substring(0, 2));
            if (artirilankisim < 21)
            {

                string[] timeParts = gunbatimi.Split(':');
                int hour = Convert.ToInt32(timeParts[0]);
                hour += 3;
                gunbatimi = hour.ToString() + ":" + timeParts[1] + ":" + timeParts[2];
            }
            else
            {
                switch (artirilankisim)
                {
                    case 21:
                        gunbatimi.Replace("21", "0");
                        break;
                    case 22:
                        gunbatimi.Replace("22", "1");
                        break;
                    case 23:
                        gunbatimi.Replace("23", "2");
                        break;
                    case 24:
                        gunbatimi.Replace("24", "3");
                        break;
                    default:
                        break;
                }
            }
            if (kontrol == true)
            {
                labelSicaklik.Text = "Sıcaklık: " + sicaklik + "°C";
                labelHissedilenSicaklik.Text = "Hissedilen Sıcaklık: " + hissedilensicaklik + "°C";
                labelHavaDurumu.Text = "Hava Durumu: " + havadurumu;
                labelRuzgarHizi.Text = "Rüzgar Hızı: " + ruzgarhizi;
                labelGunDogumu.Text = "Gün Doğumu: " + gundogumu;
                labelGunBatimi.Text = "Gün Batımı: " + gunbatimi;
                labelSehir.Text = "Şehir: " + sehir;
                labelNem.Text = "Nem Yüzdesi: " + nem;
                labelBulutDurumu.Text = "Bulut Durumu: " + bulutdurumu;
                labelBasınç.Text = "Basınç: " + basinc;
            }
            else if (kontrol == false)
            {
                labelSicaklik.Text = "";
                labelHissedilenSicaklik.Text = "";
                labelHavaDurumu.Text = "";
                labelRuzgarHizi.Text = "";
                labelGunDogumu.Text = "";
                labelGunBatimi.Text = "";
                labelSehir.Text = "";
                labelNem.Text = "";
                labelBulutDurumu.Text = "";
                labelBasınç.Text = "";
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sehirr = textBox1.Text;
                havaDurumuAl(sehirr);
            }
        }
        
    }
}
