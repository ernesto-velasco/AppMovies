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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            LblRegClickFunc();
            LblResClickFunc();

        }
        private async void btnTabsHomePage_Clicked(object sender, EventArgs e)
        {
            if (Navigation != null)
            {
                Navigation.InsertPageBefore(new TabMenu(), this);
                await Navigation.PopAsync().ConfigureAwait(false);
            }
        }
        public void LblRegClickFunc()
        {
            LblRegClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    var page = new RegisterPage();
                    Navigation.PushAsync(page);
                    NavigationPage.SetHasNavigationBar(page, false);
                })
            });
        }
        public void LblResClickFunc()
        {
            LblResClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    var page = new RestorePasswordPage();
                    Navigation.PushAsync(page);
                    NavigationPage.SetHasNavigationBar(page, false);
                })
            });
        }
    }
}