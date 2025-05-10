using Microsoft.EntityFrameworkCore;
using SanaVitaAPI.Data;
using SanaVitaAPI.Interfaces;
using SanaVitaAPI.Middleware;
using SanaVitaAPI.Repositories;
using SanaVitaAPI.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Serilog Configuration
Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File("Logs/sanavita-log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

// Add Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Fallback System State
builder.Services.AddSingleton<FallbackState>();

// Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMedicationRequestRepository, MedicationRequestRepository>();
builder.Services.AddScoped<IMedicationScheduleRepository, MedicationScheduleRepository>();
builder.Services.AddScoped<IAdministrationRepository, AdministrationRepository>();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();


var app = builder.Build();

// Middleware Pipeline
app.UseSwagger();
app.UseSwaggerUI();

//Exception Handling (global)
app.UseExceptionHandling();

// Audit Logging
app.UseAuditLogging();

// Fallback Mode Enforcement
app.UseFallbackCheck();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
