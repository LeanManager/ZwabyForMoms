using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class MessagesPage : ContentPage
	{
		public MessagesPage()
		{
			InitializeComponent();

			this.Padding = new Thickness(10, 30, 10, 0);

			testLabel.Text = "Your booking has been confirmed for Monday, May 1st at 8:30am.\nYou will find details in 'Current Booking'";
		}
	}
}
