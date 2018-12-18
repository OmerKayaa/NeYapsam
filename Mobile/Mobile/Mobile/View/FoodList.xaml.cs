﻿using Mobile.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodList : ContentPage
	{
		public FoodList ()
		{
			InitializeComponent ();
            Content = new Content(new List<Card> { new Card("carrot.png","Havuç"),
            new Card("carrot.png","Havuç"),
            new Card("carrot.png","Havuç"),
            new Card("carrot.png","Havuç"),
            new Card("carrot.png","Havuç"),
            new Card("carrot.png","Havuç"),
            });
		}

        private async void SettingsEvent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void LoginEvent(object sender, EventArgs e)
        {
            if(App.Login)
                await Navigation.PushAsync(new User());
            else
                await Navigation.PushAsync(new LoginPage());
        }
    }
}