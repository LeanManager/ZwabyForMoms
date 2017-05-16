using System.Threading.Tasks;
using Xamarin.FormsBook.Toolkit;

namespace ZwabyBeta.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task NavigateBackAsync();
    }
}
