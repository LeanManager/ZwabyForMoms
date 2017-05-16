using System.Threading.Tasks;
using ZwabyBeta.Models.Common;

// Is it right namespace or just copypaste?
namespace Xamarin.FormsBook.Toolkit
{
    public class ViewModelBase : BindableBase
	{
		public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
	}
}