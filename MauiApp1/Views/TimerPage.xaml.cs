
//using Android.Media;
using MauiApp1.ViewModel;
using Plugin.Maui.Audio;

namespace MauiApp1.Views;

public partial class TimerPage : ContentPage
{
    private bool _isPlaying;
    private readonly IAudioManager audioManager;

    public TimerPage(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
        BindingContext = new TimerViewModel();
    }
}
