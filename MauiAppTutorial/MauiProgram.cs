using MauiAppTutorial.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiAppTutorial
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .Services
                .AddSingleton<IConnectivity>(Connectivity.Current) // Singleton is created once and shared throughout the app.
                .AddSingleton<MainPage>()
                .AddSingleton<MainViewModel>()

                .AddTransient<DetailPage>() // Transients get created each time they are requested and destroyed after use.
                .AddTransient<DetailViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
