//using Com.Google.Android.Exoplayer2;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class TimerViewModel : BaseViewModel
    {
        private TimeSpan _initialTime = TimeSpan.FromMinutes(5);
        private TimeSpan _elapseTime = TimeSpan.FromSeconds(0);
        private CancellationTokenSource _cancellationTokenSource;
        private IAudioPlayer _audioPlayer;

        [ObservableProperty]
        private string remainingTime;

        [ObservableProperty]
        private string timerInput;
        private readonly IAudioManager audioManager;

        public TimerViewModel()
        {
            RemainingTime = _initialTime.ToString(@"mm\:ss");
            TimerInput = "5"; // Default value
        }

        [RelayCommand]
        private async Task Start()
        {
            if (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
                return;

            if (!int.TryParse(TimerInput, out int minutes) || minutes <= 0)
            {
                RemainingTime = "Invalid Input";
                return;
            }

            _initialTime = TimeSpan.FromMinutes(minutes);
            RemainingTime = _initialTime.ToString(@"mm\:ss"); 

            _cancellationTokenSource = new CancellationTokenSource();

            _initialTime = _initialTime - _elapseTime;
            await RunTimer(_initialTime, _cancellationTokenSource.Token);
        }

        [RelayCommand]
        private void Stop()
        {
            if (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Cancel();
            }

            _cancellationTokenSource = null;

            _audioPlayer?.Pause();
        }

        [RelayCommand]
        private void Reset()
        {
            Stop();
            if (!int.TryParse(TimerInput, out int minutes) || minutes <= 0)
            {
                RemainingTime = "Invalid Input";
                return;
            }


            _audioPlayer?.Stop();
            _audioPlayer?.Dispose();
            _audioPlayer = null;


            _initialTime = TimeSpan.FromMinutes(minutes);
            RemainingTime = _initialTime.ToString(@"mm\:ss");
            _elapseTime = TimeSpan.FromSeconds(0);
        }

        private async Task RunTimer(TimeSpan countdownTime, CancellationToken token)
        {
            try
            {
                var audioSource = await FileSystem.OpenAppPackageFileAsync("sample.mp3");

                //var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync ("sample.mp3"));

                _audioPlayer = AudioManager.Current.CreatePlayer(audioSource);
                _audioPlayer.Play();

                while (countdownTime.TotalSeconds > 0)
                {
                    if (token.IsCancellationRequested)
                        break;

                    await Task.Delay(1000, token);

                    
                    _elapseTime = _elapseTime.Add(TimeSpan.FromSeconds(1));

                    countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1));
                    RemainingTime = countdownTime.ToString(@"mm\:ss");
                }
                
            }
            catch (TaskCanceledException ex)
            {
                // empty
            }
        }
    }
}



