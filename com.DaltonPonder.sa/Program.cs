using Blazored.LocalStorage;
using com.DaltonPonder.sa.Extensions;
using com.DaltonPonder.sa;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddLocalization();
builder.Services.AddBlazoredLocalStorage();

var host = builder.Build();
await host.SetDefaultUICulture(host.Services.GetRequiredService<IJSRuntime>());

await builder.Build().RunAsync();
