using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vulkan2Blazor;
using Vulkan2Blazor.Components;
using Microsoft.Extensions.DependencyInjection;
using Vulkan2Blazor.Components.Account;
using Vulkan2Blazor.Data;
using Vulkan2Blazor.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContextFactory<Vulkan2Context>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Vulkan2Context") ??
                          throw new InvalidOperationException("Connection string 'Vulkan2Context' not found.")));
}
else
{
    builder.Services.AddDbContextFactory<Vulkan2Context>(options =>
        options.UseNpgsql(Environment.GetEnvironmentVariable("AZURE_POSTGRESQL_CONNECTIONSTRING") ??
                          throw new InvalidOperationException("Connection string 'AZURE_POSTGRESQL_CONNECTIONSTRING' not found.")));
}
;

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<Vulkan2Context>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Fallback authorization policy
// builder.Services.AddAuthorizationBuilder()
//     .SetFallbackPolicy(new AuthorizationPolicyBuilder()
//         .RequireAuthenticatedUser()
//         .Build());

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();
    
    
// Seed the database with roles and users
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await RoleSeeder.SeedRoles(services);
    await UserSeeder.SeedAdminUser(services);
}

app.Run();