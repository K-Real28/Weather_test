using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Weather_test
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string apiKey = "2b70ae47ee75a13a312dfd16bd595ad7";
        private Size originalSize;

        public Form1()
        {
            InitializeComponent();
            ImgSun.Visible = false;
            originalSize = svgReset.Size;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string cityName = inputNameCity.Text;
            string weather = await GetWeatherAsync(cityName);
            label1.Text = weather;

        }
        private async Task<string> GetWeatherAsync(string city)
        {
            try
            {
                string encodedCity = Uri.EscapeDataString(city);
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={encodedCity}&appid={apiKey}&units=metric&lang=ru";
                var response = await client.GetStringAsync(url);
                var weatherData = JObject.Parse(response);

                string temperature = weatherData["main"]["temp"].ToString();
                string feelsLike = weatherData["main"]["feels_like"].ToString();
                string humidity = weatherData["main"]["humidity"].ToString();
                string pressure = weatherData["main"]["pressure"].ToString();
                string windSpeed = weatherData["wind"]["speed"].ToString();
                string weatherDescription = weatherData["weather"][0]["description"].ToString();

                ViewDescription(weatherDescription);


                return $"Температура: {temperature} °C\n" +
                       $"Ощущается как: {feelsLike} °C\n" +
                       $"Влажность: {humidity}%\n" +
                       $"Давление: {pressure} гПа\n" +
                       $"Скорость ветра: {windSpeed} м/с\n" +
                       $"Описание: {weatherDescription}";
            }
            catch (Exception ex)
            {
                return "Ошибка: " + ex.Message;
            }
        }
        public void ViewDescription(string weatherDescription)
        {
            switch (weatherDescription)
            {
                case "пасмурно":
                    ImgSmallRain.Visible = true;
                    ImgSmallRain.BringToFront();
                    Form1.ActiveForm.BackColor = Color.Silver;
                    inputNameCity.BackColor = Color.Silver;
                    break;
                case "облачно с прояснениями":
                    Form1.ActiveForm.BackColor = Color.LightGreen;
                    imgSunCloud.Visible = true;
                    imgSunCloud.BringToFront();
                    inputNameCity.BackColor = Color.LightGreen;
                    break;
                case "ясно":
                    Form1.ActiveForm.BackColor = Color.Goldenrod;
                    ImgSun.Visible = true;
                    ImgSun.BringToFront();
                    inputNameCity.BackColor = Color.Goldenrod;
                    break;
                case "снег":
                    Form1.ActiveForm.BackColor = Color.MediumTurquoise;
                    ImgSnow.Visible = true;
                    ImgSnow.BringToFront();
                    inputNameCity.BackColor = Color.MediumTurquoise;
                    break;
                default:
                    Reset();
                    break;
            }
        }
        public void Reset()
        {
            inputNameCity.BackColor = Color.WhiteSmoke;
            Form1.ActiveForm.BackColor = Color.WhiteSmoke;
            ImgSmallRain.Visible = false;
            imgSunCloud.Visible = false;
            ImgSun.Visible = false;
            ImgSnow.Visible = false;
        }
        private async void btnMurmansk_Click(object sender, EventArgs e)
        {
            inputNameCity.Text = "Мурманск";
            string weather = await GetWeatherAsync("Мурманск");
            label1.Text = weather;
        }

        private async void btn_Tiraspol_Click(object sender, EventArgs e)
        {
            inputNameCity.Text = "Тирасполь";
            string weather = await GetWeatherAsync("Тирасполь");
            label1.Text = weather;
        }

        private async void btnStambul_Click(object sender, EventArgs e)
        {
            inputNameCity.Text = "Стамбул";
            string weather = await GetWeatherAsync("Стамбул");
            label1.Text = weather;
        }

        private async void btnlondon_Click(object sender, EventArgs e)
        {
            inputNameCity.Text = "Лондон";
            string weather = await GetWeatherAsync("Лондон");
            label1.Text = weather;
        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {
            inputNameCity.Text = "";
            label1.Text = "";

            Reset();
        }
        private void svgReset_MouseEnter(object sender, EventArgs e)
        {
            svgReset.Width = (int)(originalSize.Width * 1.1);
            svgReset.Height = (int)(originalSize.Height * 1);
        }
        private void svgReset_MouseLeave(object sender, EventArgs e)
        {
            svgReset.Width = originalSize.Width;
            svgReset.Height = originalSize.Height;
        }
    }
}
