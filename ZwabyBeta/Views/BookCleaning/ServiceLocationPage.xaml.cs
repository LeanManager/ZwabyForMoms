using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class ServiceLocationPage : ContentPage
	{
		public ServiceLocationPage()
		{
			InitializeComponent();

			this.Padding = new Thickness(15, 25, 15, 25);

			residencePicker.Title = "House or Apartment";
		}

		// Instead of event handlers in code-behind page, use Command with XAML markup extensions (data binding) => ViewModel.

		// The visual elements in the View are data-binding targets, and properties in the ViewModel are data-binding sources.

		// Visual elements in the View qualify as data-binding targets because the properties of these visual elements 
		// are backed by bindable properties. To be a data-binding source, a ViewModel must implement a notification protocol 
		// to signal when a property in the ViewModel has changed. This notification protocol is the INotifyPropertyChanged interface, 
		// which is defined in the System.Component- Model namespace very simply with just one event.


		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			// 2 buttons so declare 2 sender variables with boolean identifier

			double result;

			if (addressEntry.Text == null || cityEntry.Text == null || stateEntry.Text == null || zipEntry.Text == null)
			{
				await DisplayAlert("Error", "Please enter valid entries.", "OK");
			}

				else if (double.TryParse(zipEntry.Text, out result) && zipEntry.Text.Length == 5)
				{
					// Get nearest cleaning professionals (from the BaseAddress property of the Cleaner objects in Database)
					// Display 3 nearest cleaning professionals in CarouselView (await user input before continuing, thanks async/await :D)

					await Navigation.PushAsync(new DayTimePage());
				}
				else
				{
					await DisplayAlert("Error", "Please enter a valid zip code.", "OK");
				}
		 }
	}
}
