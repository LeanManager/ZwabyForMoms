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

			this.Padding = new Thickness(0, 30, 0, 0);

			testLabel.Text = "Your booking has been confirmed for Tuesday, March 21st at 8:30am.\nYou will find details in 'Current Bookings'";
		}
	}
}
