
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabMenu : TabbedPage
    {
        public TabMenu ()
        {
            InitializeComponent();
        }
        private async void btnTabsProfilePage_Clicked(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                await Navigation.PushAsync(new ProfilePage());
            }
        }
        private async void btnMovieDetailsPage_Clicked(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                var page = new MovieDetailsPage();
                await Navigation.PushAsync(page);
                NavigationPage.SetHasNavigationBar(page,false);
            }
        }
        private async void btnLoginPage_Clicked(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                var page = new LoginPage();
                await Navigation.PushAsync(page);
                NavigationPage.SetHasNavigationBar(page, false);
            }
        }
    }
}