using Microsoft.Extensions.Logging;
using AskYoda.ViewModel;
using AskYoda.View;
namespace AskYoda
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
            builder.RegisterViewModel()
                   .RegisterView();

            return builder.Build();
        }

        public static MauiAppBuilder RegisterViewModel(this MauiAppBuilder mauiAppbuilder)
        {
            mauiAppbuilder.Services.AddSingleton<YodaViewModel>();
            return mauiAppbuilder;
        }
        public static MauiAppBuilder RegisterView(this MauiAppBuilder mauiAppbuilder)
        {
            mauiAppbuilder.Services.AddSingleton<babyYoda>();
            return mauiAppbuilder;
        }


    }
}
