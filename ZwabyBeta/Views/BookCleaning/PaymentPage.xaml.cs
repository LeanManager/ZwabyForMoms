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

			//this.Padding = new Thickness(12, 25, 10, 15);
			labelStack.Padding = new Thickness(0, 5, 0, 25);

			// Pass in bedroom and bathroom parameters from last page into this Page's constructor
			// and use them to generate duration and rate.
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			// TODO: Conditional validation code: Stripe API

			// Update empty label in 'Messages' page

			if (cardName.Text != null && cardNumber.Text != null && expDate != null && cardCode != null && cardZip != null)
			{

				if (cardNumber.Text.Length == 15 || cardNumber.Text.Length == 16)
				{
					await DisplayAlert("Success!", "Your booking has been confirmed. You will find details in 'Current Bookings'", "OK");

					Navigation.InsertPageBefore(new MainPage(), this);
					await Navigation.PopAsync().ConfigureAwait(false);
				}

				else
				{
					await DisplayAlert("Error", "Please enter a valid card number.", "OK");
				}

			}
			else
			{
				await DisplayAlert("Error", "Please enter valid entries.", "OK");
			}
			// Return user to main page

			// await Navigation.PopToRootAsync();

			// Navigation.InsertPageBefore(new MainPage(), this);
			// await Navigation.PopAsync().ConfigureAwait(false);

			// Update CurrentBookings ListView for both customer and cleaning professional
		}
	}
}
