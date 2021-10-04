using Microsoft.OpenApi.Models;
using Sample.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<PersonContext>(option => {
    
});
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Sample", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sample v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

// app.Configuration.GetConnectionString("ConnectionString");
// app.AddDbContext<PersonContext>(option => {
//     option.UseNpgsql("Host=db;Database=dev;Username=dev;Password=password");
// });

app.MapControllers();

app.Run();
