using CarRental;
using CarRental.Business.Classes;
using CarRental.Common.Classes;
using CarRental.Common.Interfaces;
using CarRental.Data.Classes;
using CarRental.Data.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IVehicle, Car>();
builder.Services.AddSingleton<IPerson, Costumer>();

builder.Services.AddSingleton<BookingProcessor>();
builder.Services.AddSingleton<IData, CollectionData>();

await builder.Build().RunAsync();