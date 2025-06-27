using Bai3.Data;
using Bai3.Repository;
using Bai3.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MyDb"));
});

builder.Services.AddScoped<ILoaiRepository, LoaiRepositoryImpl>();
builder.Services.AddScoped<IHangHoaRepository, HangHoaRepositoryImpl>();

builder.Services.AddScoped<ILoaiServices, LoaiServicesImpl>();
builder.Services.AddScoped<IHangHoaService, HangHoaServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
