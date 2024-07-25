
using MauiApp1.ViewModel;
using Plugin.Maui.Audio;

namespace MauiApp1.Views;

public partial class TimerPage : ContentPage
{
    private bool _disposed = false;
    private readonly IAudioManager audioManager;

    public TimerPage(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
        BindingContext = new TimerViewModel();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        if (!_disposed)
        {
            _disposed = true;
        }
        else
        {
            _disposed = false;
        }

        var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync
            ("sample.mp3"));
        if (_disposed)
        {
            player.Play();
        }
        else
        {
            player.Dispose();
        }

    }

}
