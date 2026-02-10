using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SignalRApi.DAL;
using SignalRApi.Hubs;
using SignalRApi.Model;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<VisitorService>();

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader()
              .AllowAnyMethod()
              .SetIsOriginAllowed(_ => true) // tüm originlere izin
              .AllowCredentials();
    });
});

builder.Services.AddDbContext<Context>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SignalRApi", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SignalRApi v1"));
}

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthorization();

// ✅ Endpoints
app.MapControllers();
app.MapHub<VisitorHub>("/VisitorHub");

app.Run();
