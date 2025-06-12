#nullable enable
<<<<<<< HEAD
using Microsoft.Extensions.DependencyInjection;
=======
>>>>>>> 99d033553243ca746c5de0a60a29c503cc145af3
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using event_card_app;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<event_card_app.Components.SessionState>();
builder.Services.AddSingleton<event_card_app.Components.AttendanceTracker>();

await builder.Build().RunAsync();