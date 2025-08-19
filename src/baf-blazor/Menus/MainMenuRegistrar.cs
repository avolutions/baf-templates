using Avolutions.Baf.Blazor.Menus;
using Avolutions.Baf.Core.Menu.Abstractions;
using Avolutions.Baf.Core.Menu.Models;
using Avolutions.Baf.Core.Menu.Services;
using MudBlazor;

namespace Baf.BlazorApp.Menus;

public class MainMenuRegistrar : IMenuRegistrar<MainMenu>
{
    public void Register(MenuProvider<MainMenu> menuProvider)
    {
        menuProvider.Add(new MenuItem
        {
            Id = "home",
            GetTitle = () => "Home",
            Url = "/",
            Icon = Icons.Material.Outlined.Home
        });
    }
}