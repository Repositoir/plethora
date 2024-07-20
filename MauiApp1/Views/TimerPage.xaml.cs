using MauiApp1.ViewModel;

namespace MauiApp1.Views;

public partial class TimerPage : ContentPage
{
    public TimerPage()
    {
        InitializeComponent();
        BindingContext = new TimerViewModel();
    }
}
