var builder = WebApplication.CreateBuilder(args);

// 👇 REQUIRED for Railway (dynamic port)
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

// Services
builder.Services.AddControllers();

var app = builder.Build();

// ❌ DO NOT use HTTPS redirection on Railway
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Health check (very important for Railway)
app.MapGet("/", () => "Indian States API is running");

app.Run();
