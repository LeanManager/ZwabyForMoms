using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class PaymentPage : ContentPage
	{
		public PaymentPage()
		{
			InitializeComponent();

			this.Padding = new Thickness(12, 15, 10, 15);
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			// TODO: Conditional validation code: Stripe API

			await DisplayAlert("Success!", "Your booking has been confirmed. You will find details in 'Current Bookings'", "OK");

			// Return user to main page

			// await Navigation.PopToRootAsync();

			Navigation.InsertPageBefore(new MainPage(), this);
			await Navigation.PopAsync().ConfigureAwait(false);

			// Update CurrentBookings ListView for both customer and cleaning professional
		}
	}
}
