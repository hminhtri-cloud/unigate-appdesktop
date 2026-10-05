var builder = WebApplication.CreateBuilder(args);

// Nạp cấu hình từ appsettings.json
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Kích hoạt Reverse Proxy
app.MapReverseProxy();

app.Run();