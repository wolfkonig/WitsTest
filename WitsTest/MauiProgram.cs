using Microsoft.Extensions.Logging;
using WitsTest.Interfaces;
using WitsTest.Platforms;
using WitsTest.ViewModels;
using WitsTest.Views;

namespace WitsTest
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
                .RegisterServices();

            Routing.RegisterRoute("welcome", typeof(WelcomeView));
            Routing.RegisterRoute("main", typeof(MainPageView));
#if DEBUG
    		builder.Logging.AddDebug();
#endif         
            return builder.Build();
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<IWelcomeService, WelcomeService>();
            builder.Services.AddTransient<WelcomeView>();
            builder.Services.AddTransient<WelcomeViewModel>();
            builder.Services.AddTransient<MainPageView>();
            builder.Services.AddTransient<MainPageViewModel>();
            return builder;
        }
    }
}
