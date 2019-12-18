using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TrackMyWalks.Views;
using TrackMyWalks.Models;

namespace TrackMyWalks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Check what Target OS Platform we are running on whenever the app starts
            if (Device.RuntimePlatform.Equals(Device.Android))
            {
                MainPage = new SplashPage();
            }
            else
            {
                // Set the root page for our application
                MainPage = new NavigationPage(new WalksMainPage());
            }
        }

        // Declare our WalkDataModel that will store our Walk Trail Details
        public static WalkDataModel SelectedItem { get; set; }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
