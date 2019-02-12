﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

// Chapter 7 — Navigation examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace NavigationExamples
{
	public partial class HomePage : ContentPage
	{

		public HomePage ()
		{
			InitializeComponent ();
		}

		protected async void navigateToPage(object sender, EventArgs args) {
			string type = (string) ((TextCell)sender).CommandParameter;
			Type pageType = Type.GetType("NavigationExamples." + type + ", NavigationExamples");
			Page page = (Page)Activator.CreateInstance(pageType);

            await this.Navigation.PushAsync(page);
		}
	}
}

