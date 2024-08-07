using IdentityModel.OidcClient;

namespace MauiApp2;

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

        // add main page
        builder.Services.AddSingleton<MainPage>();

        // setup OidcClient
        builder.Services.AddSingleton(new OidcClient(new()
        {
          Authority = "https://tdkeycloak.azurewebsites.net/auth/realms/Technidata",
          ClientId = "tdnexlabs",
          Scope = "openid profile email",
          RedirectUri = "http://127.0.0.1/sample-wpf-app",
          //RedirectUri = "myapp://callback",

          Browser = new MauiAuthenticationBrowser()
        }));

        return builder.Build();
    }
}