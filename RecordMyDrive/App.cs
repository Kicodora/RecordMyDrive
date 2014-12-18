using System;
using Xamarin.Forms;

namespace RecordMyDrive
{
	public class App
	{	
		/*static ContentPage mainPage = new ContentPage {
			Title = "Record My Drive",
			/*Content = new Label {
				Text = "Hello, Forms!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			}
			Content = new StackLayout {
				Spacing = 20,
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "Disclaimer:" },
					new Button { 
						Text = "Begin",
						BackgroundColor = Color.FromRgb(1, 100, 1)
					}
				}
			}
		};

		static ContentPage profilePage = new ContentPage {
			Title = "Settings",
			Icon = "Icon.png",
			Content = new StackLayout {
				Spacing = 20, 
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Entry { Placeholder = "Username" },
					new Entry { Placeholder = "Password", IsPassword = true },
					new Button {
						Text = "Login",
						TextColor = Color.White,
						BackgroundColor = Color.FromHex("77D065") 
					}
				}
			}
		};*/
		static ContentPage mainPage = new Main();

		public static Page GetMainPage ()
		{
			return new TabbedPage { Children = { mainPage, mainPage } };
		}
	}
}

