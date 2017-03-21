using Xamarin.Forms;
// using SQLitePCL;

namespace ZwabyBeta
{
	public partial class App : Application
	{
		// TODO: Splash screen with Zwaby logo as background image as Navigation initializer

		public App()
		{
			InitializeComponent();

			// if statement. Check registrationStatus boolean, then assign a nav page accordingly
			// check customer ID and registrationStatus in SQLite Database
			// function that takes int ID and returns boolean registrationStatus

			MainPage = new NavigationPage(new RegistrationPage());
		}

		// Azure SQL cloud database service instead?

		static CustomerDatabase database;

		public static CustomerDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new CustomerDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("CustomerSQLite.db3"));
				}

				return database;
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
} 

