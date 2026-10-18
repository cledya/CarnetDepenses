using CarnetDepenses.Services;
using CarnetDepenses.ViewModels;
using Microsoft.Extensions.Logging;

namespace CarnetDepenses
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
                });

#if DEBUG
    		builder.Logging.AddDebug();

            builder.Services.AddSingleton<IDepenseRepository,
                              JsonDepenseRepository>();
            builder.Services.AddSingleton<DepensesViewModel>();
            builder.Services.AddSingleton<MainPage>();
#endif

            return builder.Build();
        }
    }
}
