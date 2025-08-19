using Baf.BlazorApp.Menus;
using Avolutions.Baf.Blazor.Menus;
using Avolutions.Baf.Core.Menu.Abstractions;
using Avolutions.Baf.Core.Module.Abstractions;

namespace Baf.BlazorApp;

public class MainModule : IFeatureModule
{
    public void Register(IServiceCollection services)
    {
        services.AddSingleton<IMenuRegistrar<MainMenu>, MainMenuRegistrar>();
    }
}