using System;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using ZwabyBeta.Services;
using ZwabyBeta.Extensions;
// using SQLitePCL;

namespace ZwabyBeta
{
	public partial class App : Application
	{
        private readonly IUnityContainer _unityContainer;

		// TODO: Splash screen with Zwaby logo as background image as Navigation initializer

		public App()
		{
			InitializeComponent();

            _unityContainer = new UnityContainer();
            ConfigureContainer();
            // if statement. Check registrationStatus boolean, then assign a nav page accordingly
            // check customer ID and registrationStatus in SQLite Database
            // function that takes int ID and returns boolean registrationStatus
            
            // Proccessing navigation OnStart instead.
			//MainPage = new NavigationPage(new RegistrationPage());
		}

        private void ConfigureContainer()
        {
            _unityContainer.RegisterSingleton<INavigationService, NavigationService>();

            _unityContainer.RegisterType<RegistrationViewModel>();
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

		protected override async void OnStart()
		{
            var navigationService = _unityContainer.Resolve<INavigationService>();
            await navigationService.NavigateToAsync<RegistrationViewModel>();
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

