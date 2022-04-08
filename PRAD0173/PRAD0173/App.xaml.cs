using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PRAD0173.Controllers;
using PRAD0173.Views;
using System.IO;

namespace PRAD0173
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DB.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PRAD0173.db3"));

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
