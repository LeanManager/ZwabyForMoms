using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class BedBathPage : ContentPage
	{
		public BedBathPage()
		{
			InitializeComponent();

			this.Padding = new Thickness(15, 25, 15, 0);

			topStack.Padding = new Thickness(0, 0, 0, 30);

			//< Label Text = "{Binding Source={x:Reference bedPicker},

			//					  Path=Items,
			//	                  StringFormat = 'Approximate duration is {0}'}"
			//   TextColor="Blue" 
			//   FontAttributes="Bold"/>
		}

		// TODO: Data binding for bed/bath <Picker/> views

		// IF userInput == integer, nothing happens. If not, display error message

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new PaymentPage());
		}
	}
}
