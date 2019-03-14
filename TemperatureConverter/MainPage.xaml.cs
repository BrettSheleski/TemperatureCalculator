using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemperatureConverter
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        const double fiveNinths = 5 / 9.0;
        const double nineFifths = 9 / 5.0;


        void HandleClear_Clicked(object sender, EventArgs e)
        {
            CelsiusEntry.Text = null;
            FahrenheitEntry.Text = null;

            CelsiusF2CEntry.Text = null;
            FahrenheitF2CEntry.Text = null;
        }

        void HandleCalculate_Clicked(object sender, EventArgs e)
        {
            string celsiusText;
            double celsiusDegrees;

            double fahrenheitDegrees;
            string fahrenheitText;


            celsiusText = CelsiusEntry.Text;

            if (double.TryParse(celsiusText, out celsiusDegrees))
            {
                fahrenheitDegrees =  (celsiusDegrees * nineFifths) + 32;

                fahrenheitText = fahrenheitDegrees.ToString();

                FahrenheitEntry.Text = fahrenheitText;
            }

        }

        void HandleF2CCalculate_Clicked(object sender, EventArgs e)
        {
            string celsiusText;
            double celsiusDegrees;

            double fahrenheitDegrees;
            string fahrenheitText;


            fahrenheitText = FahrenheitF2CEntry.Text;

            if (double.TryParse(fahrenheitText, out fahrenheitDegrees))
            {
                celsiusDegrees = (fahrenheitDegrees - 32) * fiveNinths;

                celsiusText = celsiusDegrees.ToString();

                CelsiusF2CEntry.Text = celsiusText;
            }
        }

    }
}
