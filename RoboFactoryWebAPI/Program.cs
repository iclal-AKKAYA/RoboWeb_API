using Microsoft.EntityFrameworkCore;
using RoboFactoryWebAPI.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


 https://aka.ms/aspnet.core/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
