using GeoTrack.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();

// ✅ ADD DATABASE (InMemory for now)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("GeoTrackDb"));

// ✅ CORS (you already have this, just kept same)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();