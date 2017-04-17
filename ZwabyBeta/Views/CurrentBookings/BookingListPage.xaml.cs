using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class BookingListPage : ContentPage
	{
		public BookingListPage()
		{
			InitializeComponent();

			currentBookings.ItemsSource = BookingManager.Bookings;
			// currentBookings.SeparatorColor = Color.Blue;

			// TODO: Platform-specific custom renderers for ListView UI details
		}

		//async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
		//{
		//	Booking selection = (Booking)e.Item;
		//	await Navigation.PushAsync(new BookingDetailsPage(selection));
		//}
	}
}
