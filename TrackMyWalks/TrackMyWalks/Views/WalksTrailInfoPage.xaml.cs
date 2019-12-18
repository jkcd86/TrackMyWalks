using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrackMyWalks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalksTrailInfoPage : ContentPage
    {
        public WalksTrailInfoPage()
        {
            InitializeComponent();

            // Update the page title for our Walk Information Page
            Title = "Trail Walk Information";

            // Set the Binding Context for our ContentPage
            this.BindingContext = App.SelectedItem;
        }

        // Instance method that proceeds to begin a new walk trail
        public void BeginTrailWalk_Clicked(object sender, EventArgs e)
        {
            if (App.SelectedItem == null)
                return;

            Navigation.PushAsync(new WalkDistancePage());
            Navigation.RemovePage(this);
        }
    }
}