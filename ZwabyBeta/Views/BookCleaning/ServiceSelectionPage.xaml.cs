using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class ServiceSelectionPage : ContentPage
	{
		public ServiceSelectionPage()
		{
			InitializeComponent();

			var ccLabel = new Label
			{
				Text = "Better Homes and Business Cleaning Service",
				TextColor = Color.Blue,
				//FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalTextAlignment = TextAlignment.Center,
				FontAttributes = FontAttributes.Bold
			};

			var ccLogo = new Image
			{
				Source = ImageSource.FromResource("ZwabyBeta.Models.bhbsample.jpg"),
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};

                        var ccRating = new Label
			{
				Text = "Angie's List rating: A+",
				TextColor = Color.Blue,
				HorizontalTextAlignment = TextAlignment.Center,
				FontAttributes = FontAttributes.Bold
			};

                        var ccYears = new Label
			{
				Text = "Established since 2006",
				TextColor = Color.Blue,
				HorizontalTextAlignment = TextAlignment.Center,
				FontAttributes = FontAttributes.Bold
			};

			ccStack.Children.Add(ccLabel);
			ccStack.Children.Add(ccLogo);
			ccStack.Children.Add(ccRating);
			ccStack.Children.Add(ccYears);
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new BedBathPage());
		}
	}
}
