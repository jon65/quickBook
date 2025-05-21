using MediatR;

var builder = WebApplication.CreateBuilder(args);



// Register MVC controllers
builder.Services.AddControllers();
// Enable routing to controllers
var app = builder.Build();
services.AddScoped<IAppointmentRepository, AppointmentRepository>();
services.AddScoped<BookAppointmentUseCase>();

app.MapControllers();
app.Run();
