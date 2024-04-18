using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using CommunityToolkit.Maui;
using AskYoda.Configuration;
using AskYoda.ViewModel;
using AskYoda.View;
using CommunityToolkit.Maui;
using AskYoda.Services;
using AskYoda.Services.Interfaces;

namespace AskYoda
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Insanibc.ttf", "Insanibc");
                fonts.AddFont("Insanibu.ttf", "Insanibu");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.RegisterServices()
                   .RegisterViewModel()
                   .RegisterView();
            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppbuilder)
        {
            mauiAppbuilder.Services.AddTransient<IAiAssistant, YodaAiAssistant>();
            mauiAppbuilder.Services.AddTransient<ISettings, ConstantSettings>();

            return mauiAppbuilder;
        }
        public static MauiAppBuilder RegisterViewModel(this MauiAppBuilder mauiAppbuilder)
        {
            mauiAppbuilder.Services.AddSingleton<AnswerViewModel>();
            return mauiAppbuilder;
        }

        public static MauiAppBuilder RegisterView(this MauiAppBuilder mauiAppbuilder)
        {
            mauiAppbuilder.Services.AddSingleton<AnswerView>();
            return mauiAppbuilder;
        }
    }
}