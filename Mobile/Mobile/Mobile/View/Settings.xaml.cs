﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
            InitializeComponent ();
		}

        private void LoginEvent(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void LogoutEvent(object sender, EventArgs e)
        {
            App.Login = null;
            App.update();
            Navigation.PopToRootAsync();
        }
    }
}