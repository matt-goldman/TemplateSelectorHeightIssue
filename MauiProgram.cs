using Microsoft.Extensions.Logging;
using TemplateSelectorHeightIssue.Pages;
using TemplateSelectorHeightIssue.ViewModels;

namespace TemplateSelectorHeightIssue
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
#endif

            builder.Services.AddTransient<FirstTabViewModel>();
            builder.Services.AddTransient<FirstTab>();

            builder.Services.AddTransient<SecondTab>();

            builder.Services.AddTransient<MainPage>();

            return builder.Build();
        }
    }
}
