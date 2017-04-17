using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.FormsBook.Toolkit;

namespace ZwabyBeta.Services
{
    public sealed class NavigationService : INavigationService
    {
        private readonly IUnityContainer _unityContainer;
        private readonly Dictionary<Type, Type> _mappings;

        private Application CurrentApplication => Application.Current;

        public NavigationService(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
            _mappings = new Dictionary<Type, Type>();

            ConfigureViewModelToViewMappings();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return ProccessNavigationAsync(typeof(TViewModel), null);
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return ProccessNavigationAsync(typeof(TViewModel), parameter);
        }

        public Task NavigateBackAsync()
        {
            return CurrentApplication.MainPage.Navigation.PopAsync();
        }

        private void ConfigureViewModelToViewMappings()
        {
            _mappings.Add(typeof(RegistrationViewModel), typeof(RegistrationPage));
        }

        private async Task ProccessNavigationAsync(Type viewModelType, object parameter)
        {
            Page page = CreateAndBindPage(viewModelType);

            var navigationPage = CurrentApplication.MainPage as NavigationPage;

            if (navigationPage != null)
            {
                await navigationPage.PushAsync(page);
            }
            else
            {
                CurrentApplication.MainPage = new NavigationPage(page);
            }

            await (page.BindingContext as ViewModelBase).InitializeAsync(parameter);
        }

        private Page CreateAndBindPage(Type viewModelType)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            ViewModelBase viewModel = _unityContainer.Resolve(viewModelType) as ViewModelBase;
            page.BindingContext = viewModel;

            return page;
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"No map for ${viewModelType} was found on navigation mappings");
            }

            return _mappings[viewModelType];
        }
    }
}
