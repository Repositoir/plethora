using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public partial class TimerViewModel : BaseViewModel
    {
        private TimeSpan _initialTime = TimeSpan.FromMinutes(5);
        private CancellationTokenSource _cancellationTokenSource;

        [ObservableProperty]
        private string remainingTime;

        public TimerViewModel()
        {
            RemainingTime = _initialTime.ToString(@"mm\:ss");
        }

        [RelayCommand]
        private async Task Start()
        {
            if (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
                return;

            _cancellationTokenSource = new CancellationTokenSource();
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
        }

        [RelayCommand]
        private void Reset()
        {
            Stop();
            RemainingTime = _initialTime.ToString(@"mm\:ss");
        }

        private async Task RunTimer(TimeSpan countdownTime, CancellationToken token)
        {
            try
            {
                while (countdownTime.TotalSeconds > 0)
                {
                    if (token.IsCancellationRequested)
                        break;

                    await Task.Delay(1000, token);
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


