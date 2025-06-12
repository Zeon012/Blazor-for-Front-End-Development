#nullable enable
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using event_card_app;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<event_card_app.Components.SessionState>();
builder.Services.AddSingleton<event_card_app.Components.AttendanceTracker>();

await builder.Build().RunAsync();