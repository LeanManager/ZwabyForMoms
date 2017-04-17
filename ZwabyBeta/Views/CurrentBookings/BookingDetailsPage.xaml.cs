using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class BookingDetailsPage : ContentPage
	{
		//public BookingDetailsPage(Booking bookingSelection)
        public BookingDetailsPage()
		{
			// var textPadding = new Thickness(5, 0, 5, 0);

			InitializeComponent();

			var image = new Image
			{
				Source = ImageSource.FromResource("ZwabyBeta.Models.blue-69762_640.jpg"),
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.Center
			};

			var cancellationButton = new Button
			{
				Text = "Cancel booking",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White
			};

			bookingDetailsStack.Children.Add(image);
			bookingDetailsStack.Children.Add(cancellationButton);

			cancellationButton.Clicked += OnCancellationClicked;

			// pushAsync cancellation page in new Button() event handler
		}

		private async void OnCancellationClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CancellationPage());
		}
	}

}
