using System;

using Xamarin.Forms;

namespace ZwabyBeta
{
	public partial class RegistrationPage : ContentPage
	{
		public RegistrationPage()
		{
			this.Title = "Welcome";
			this.BackgroundColor = Color.Aqua;
			//this.BackgroundColor = Color.FromHex("#98f5ff");
			this.Padding = new Thickness(0, 12, 0, 15);

			var button1 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Facebook"
			};

			var button2 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Google"
			};

			var button3 = new Button
			{
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
				BackgroundColor = Color.White,
				Text = "Sign Up"
			};


			var buttonStack = new StackLayout();
			//{
				// VerticalOptions = LayoutOptions.CenterAndExpand,
				// HorizontalOptions = LayoutOptions.FillAndExpand,

			//};

			buttonStack.Children.Add(button1);
			// button1.Clicked += Facebook API;

			buttonStack.Children.Add(button2);
			// button2.Clicked += Google API;

			buttonStack.Children.Add(button3);
			button3.Clicked += Clicked;

			buttonStack.Spacing = 17;


			var stack = new StackLayout
			{
				Children =
				{
					new Label
					{
						Text = "Welcome to Zwaby!",
						FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
						VerticalTextAlignment = TextAlignment.Center,
						HorizontalTextAlignment = TextAlignment.Center,
						TextColor = Color.Blue,
						BackgroundColor = Color.Aqua,
						FontAttributes = FontAttributes.Bold
					},
					new Image
				    {
				     Source = ImageSource.FromResource("ZwabyBeta.Models.blue-69762_640.jpg"),
				     VerticalOptions = LayoutOptions.Start,
				     HorizontalOptions = LayoutOptions.Center
					},
					new Label
					{
						Text = "Please choose a registration method:",
						VerticalTextAlignment = TextAlignment.End,
						HorizontalTextAlignment = TextAlignment.Center,
						TextColor = Color.Blue,
						BackgroundColor = Color.Aqua,
						FontAttributes = FontAttributes.Bold
					},
				}
			};
			stack.Spacing = 12;
			stack.Children.Add(buttonStack);
			//Content = stack;

			var scrollView = new ScrollView();
			scrollView.Content = stack;
			Content = scrollView;
		}

		private async void Clicked(object sender, EventArgs e)
		{
			// push Navigation
			await Navigation.PushAsync(new RegistrationFormPage());
		}

	}
}

