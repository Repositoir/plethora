using CommunityToolkit.Maui;
using MauiApp1.Views;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            
            builder.Services.AddSingleton<TimerPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton(AudioManager.Current);

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
