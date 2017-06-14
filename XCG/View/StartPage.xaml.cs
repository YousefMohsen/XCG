using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XCG
{
	public partial class StartPage : ContentPage
	{
		public StartPage()
		{
			InitializeComponent();
		}



 	 async void playButton(object sender, EventArgs e) { 
		
			await Navigation.PushAsync(new WorldPage());
		
		
		}


	}
}
/*
 * 
 * async void OnNextPageButtonClicked(object sender, EventArgs e)
{
	await Navigation.PushAsync(new Page2());
		}
 */