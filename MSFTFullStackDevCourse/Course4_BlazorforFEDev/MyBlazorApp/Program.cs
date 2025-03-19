using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Course4_BlazorforFEDev.MyBlazorApp;
using Course4_BlazorforFEDev.MyBlazorApp.services; // Ensure this matches the namespace of ApiService

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register ApiService
builder.Services.AddScoped<ApiService>();

await builder.Build().RunAsync();
