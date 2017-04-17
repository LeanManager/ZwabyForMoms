using System;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public class MainPage : ContentPage
	{
		// Add Profile item on NavigationBar. Platform specific~

		public MainPage()
		{
			NavigationPage.SetHasBackButton(this, false);
			this.Title = "Home";
			this.BackgroundColor = Color.Aqua;
			this.Padding = new Thickness(0, 25, 0, 0);


			var button1 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Book Cleaning"
			};

			var button2 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Current Booking"
			};

			var button3 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Messages"
			};

			var button4 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Profile"
			};


			var buttonStack = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand
				// HorizontalOptions = LayoutOptions.FillAndExpand

			};

			buttonStack.Children.Add(button1);
			button1.Clicked += OnBookCleaning;

			buttonStack.Children.Add(button2);
			button2.Clicked += OnCurrentBookings;

			buttonStack.Children.Add(button3);
			button3.Clicked += OnMessages;

			buttonStack.Children.Add(button4);
			button4.Clicked += OnProfile;

			buttonStack.Spacing = 15;
			// buttonStack.Padding = new Thickness(5, 0, 5, 0);


			var stack = new StackLayout
			{
				Children =
				{
					new Image
				   {
				   Source = ImageSource.FromResource("ZwabyBeta.Models.blue-69762_640.jpg"),
				   VerticalOptions = LayoutOptions.Start,
				   HorizontalOptions = LayoutOptions.Center
					}
				}
			};

			stack.Children.Add(buttonStack);
			//Content = stack;

			var scroll = new ScrollView();
			scroll.Content = stack;
			Content = scroll;
		}

		private async void OnBookCleaning(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ServiceLocationPage());
		}

		private async void OnCurrentBookings(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new BookingDetailsPage());
		}

		private async void OnMessages(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MessagesPage());
		}

		private async void OnProfile(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CustomerProfilePage());
		}
	}
}

