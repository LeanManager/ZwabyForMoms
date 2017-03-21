using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class RegistrationFormPage : ContentPage
	{
		public RegistrationFormPage()
		{
			InitializeComponent();
		}

		// Submit form button event handler creates a new Customer { ... }
		// SQLite connection

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			Button button = (Button)sender;

			if (button == button1)
			{
				// store entries in database

				if (fn.Text == null || ln.Text == null || pn.Text == null || ea.Text == null)
				{
					await DisplayAlert("Error", "Please enter valid entries", "OK");
				}

				else
				{
					var newCustomer = new Customer
					{
						FirstName = fn.Text,
						LastName = ln.Text,
						EmailAddress = ea.Text,
						PhoneNumber = double.Parse(pn.Text),
					};

					// No need for data binding to code behind. Bind to ViewModels~
					// newCustomer = (Customer)BindingContext;

					await App.Database.SaveCustomerAsync(newCustomer);

					await DisplayAlert("Wait", "One-time password verification message is on its way!", "OK");

					// API to send OTP to verify user identity
				}
			}
			else
			{
				// verify OTP in password Entry with conditional function

				await DisplayAlert("Confirmation", "Your registration has been received.\n An email confirmation will be sent shortly.", "OK");

				// Navigation.InsertPageBefore(new MainPage(), this);
				// await Navigation.PopAsync().ConfigureAwait(false);

				await Navigation.PushAsync(new MainPage());

				// await Navigation.PushAsync(new NavigationPage(new MainPage()));

				// invoke class/method to create a string with the registration information.

				// use email APIs (dependency service) to send aforementioned string.

			}

		}

	}
}
