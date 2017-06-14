using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XCG.View;

namespace XCG
{
	public partial class WorldPage : ContentPage
	{
		public WorldPage()
		{
			InitializeComponent();
		}

        async void ContinentButton(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ContinentPage());

        }
    }
}
