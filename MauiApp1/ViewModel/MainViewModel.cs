using CommunityToolkit.Mvvm.Input;
using MauiApp1.Views;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            NavigateToPageCommand = new AsyncRelayCommand<string>(NavigateToPage);
        }

        public IAsyncRelayCommand<string> NavigateToPageCommand { get; }

        private async Task NavigateToPage(string pageName)
        {
            if (pageName == "TimerPage")
            {
                await Shell.Current.GoToAsync(nameof(TimerPage));
            }
        }
    }
}

