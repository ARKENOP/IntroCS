using Geometrie.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//On ajoute une instance de la classe Point_Service
builder.Services.AddSingleton<Point_Service>(new Point_Service());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
