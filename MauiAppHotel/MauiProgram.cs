using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Roboto_Condensed-BoldItalic.ttf", "RobotoCondensedBoldItalic");
                    fonts.AddFont("Roboto_Condensed-LightItalic.ttf", "RobotoCondensedLightItalic");
                    fonts.AddFont("Roboto_Condensed-MediumItalic.ttf", "RobotoCondensedMediumItalic");
                    fonts.AddFont("Roboto_Condensed-SemiBoldItalic.ttf", "RobotoCondensedSemiBoldItalic");
                    fonts.AddFont("Roboto-BlackItalic.ttf", "RobotoBlackItalic");
                    fonts.AddFont("Roboto_SemiCondensed-Regular.ttf", "RobotoReg");

                });
            

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
