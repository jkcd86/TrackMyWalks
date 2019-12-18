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
    public partial class WalkEntryPage : ContentPage
    {
        public WalkEntryPage()
        {
            InitializeComponent();

            // Update the page title for the walks entry page
            Title = "New Walk Entry Page";
        }

        // Instance method that saves the new walk entry
        public void SaveWalkItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync(true);
        }
    }
}