using AppMovies.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovies
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            //MainPage = new AppMovies.MainPage();
            var page = new LoginPage();
            NavigationPage.SetHasNavigationBar(page, false);
            MainPage = new NavigationPage(page);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
