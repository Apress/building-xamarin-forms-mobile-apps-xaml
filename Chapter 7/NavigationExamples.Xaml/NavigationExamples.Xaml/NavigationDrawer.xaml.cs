﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExamples
{
	public partial class NavigationDrawer : MasterDetailPage
	{
		public NavigationDrawer ()
		{
			InitializeComponent ();

			string[] myPageNames = { "Home", "Second", "Third" };
			menu.ItemsSource = myPageNames;

			menu.ItemTapped += (sender, e) =>
			{
				ContentPage gotoPage;
				switch (e.Item.ToString())
				{
				case "Home":
					gotoPage = new HomePage();
					break;
				case "Second":
					gotoPage = new SecondPage();
					break;
				case "Third":
					gotoPage = new ThirdPage();
					break;
				default:
					gotoPage = new NavigationPage1();
					break;
				}
				Detail = new NavigationPage(gotoPage);
				((ListView)sender).SelectedItem = null; 
				this.IsPresented = false;
			};

            NavigationPage navbar = new NavigationPage(new HomePage());
            if (Device.RuntimePlatform == Device.Android)
            {
                navbar.BarTextColor = Color.White; // because Android sets text to Black (on Black) 
            }
            Detail = navbar;
		}
	}
}

