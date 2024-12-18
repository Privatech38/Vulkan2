using Microsoft.EntityFrameworkCore;
using Vulkan2Blazor;
using Vulkan2Blazor.Components;
using Microsoft.Extensions.DependencyInjection;
using Vulkan2Blazor.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<Vulkan2Context>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Vulkan2Context") ?? throw new InvalidOperationException("Connection string 'Vulkan2Context' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();