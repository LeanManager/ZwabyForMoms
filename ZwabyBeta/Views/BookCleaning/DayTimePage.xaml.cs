using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class DayTimePage : ContentPage
	{
		public DayTimePage()
		{
			InitializeComponent();

			this.Padding = new Thickness(0, 30, 0, 0);

			timePicker.Title = "8:30 AM or 1:30 PM";

			// platform-specific custom renderers for more specific day/time Pickers
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			// TODO: display 3 nearest + available cleaning professionals

			// store Date and Time variables (to be referenced in subsequent views)

			await Navigation.PushAsync(new ServiceSelectionPage());
		}
	}
}
