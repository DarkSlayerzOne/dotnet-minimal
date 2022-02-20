using Rooster.API;
using Rooster.Data;
using Rooster.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IRoosterData, RoosterData>();
builder.Services.AddScoped<IRoosterService, RoosterService>();
builder.Services.AddSingleton<IRoosterEndpoint, RoosterEndpoint>();

var app = builder.Build();

var apis = app.Services.GetServices<IRoosterEndpoint>();
foreach(var api in apis)
{
    api.Register(app);
}

app.Run();


