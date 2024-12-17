using ExpenseHound;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ExpenseHound.Services;
using Microsoft.Extensions.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//TODO: Need to work on this for the API.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5029/Expense") });
builder.Services.AddScoped<ExpenseService>();
builder.Services.AddHttpClient();
builder.Services.AddScoped<AuthService>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();
