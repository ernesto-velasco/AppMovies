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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
            LblLogClickFunc();

        }
        private async void btnTabsHomePage_Clicked(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                Navigation.InsertPageBefore(new TabMenu(), this);
                await Navigation.PopAsync().ConfigureAwait(false);
            }
        }
        public void LblLogClickFunc()
        {
            LblLogClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    var page = new LoginPage();
                    Navigation.PushAsync(page);
                    NavigationPage.SetHasNavigationBar(page, false);
                })
            });
        }
	}
}