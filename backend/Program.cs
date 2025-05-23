using MediatR;
using Microsoft.EntityFrameworkCore;
using quickBook.Infra.Data.Context;
using quickBook.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// ✅ Register ApplicationDbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))); // UseMySql or UseSqlServer


// Register MVC controllers
builder.Services.AddControllers();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<BookAppointmentUseCase>();

// Enable routing to controllers
var app = builder.Build();

app.MapControllers();
app.Run();
