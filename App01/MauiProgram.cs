using Aplicacion.CasosDeUso;
using Microsoft.Extensions.Logging;

namespace App01
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
                // Registrar los servicios de la app
            builder.Services.AddTransient<ObtenerMesas>();
#endif
            return builder.Build();
        }
    }
}
