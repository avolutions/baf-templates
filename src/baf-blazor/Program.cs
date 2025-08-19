using Baf.BlazorApp.Components;
using Baf.BlazorApp.Data;
using Avolutions.Baf.Blazor.Extensions;
using Avolutions.Baf.Core.Identity.Extensions;
using Avolutions.Baf.Core.Module.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
);

builder.Services.AddBafCore<ApplicationDbContext>()
    .AddBafIdentity()
    .AddBafBlazor();

var app = builder.Build();

app.UseBafCore()
    .UseBafIdentity()
    .UseBafBlazor<App>();

app.Run();
