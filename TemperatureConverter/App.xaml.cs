using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TemperatureConverter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Page startPage = new MainPage();

            NavigationPage navPage = new NavigationPage(startPage);

            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
