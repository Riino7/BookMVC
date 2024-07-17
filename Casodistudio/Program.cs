using Casodistudio.Data;
using Casodistudio.Repo;
using Casodistudio.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnect"));
    });
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<IBookRepository, BookRepository>();
    // l'arrowFunction serve a connettersi al database

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();