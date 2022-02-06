using Easy.Portal.Web.Brokers.API;
using Easy.Portal.Web.Brokers.Logging;
using Easy.Portal.Web.Models.Configurations;
using RESTFulSense.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(options =>
{
    options.RootDirectory = "/Views/Pages";
});
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient<IRESTFulApiFactoryClient, RESTFulApiFactoryClient>(client =>
{
    LocalConfigurations localConfigurations = builder.Configuration.Get<LocalConfigurations>();
    var apiUrl = localConfigurations.ApiConfigurations.Url;
    client.BaseAddress = new Uri(apiUrl);

});

builder.Services.AddScoped<ILogger, Logger<LoggingBroker>>();
builder.Services.AddScoped<IApiBroker, ApiBroker>();
builder.Services.AddScoped<ILoggingBroker, LoggingBroker>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

