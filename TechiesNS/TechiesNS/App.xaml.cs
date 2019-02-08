using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TechiesNS.Views;
using Techies.Common.XF;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TechiesNS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            PreserveLinker.Preserve();

            MainPage = new MainPage();
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
