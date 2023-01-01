using Microsoft.EntityFrameworkCore;
using EnumDemo.Data;
using EnumDemo.Entities;
using Npgsql;

var dataSourceBuilder = new NpgsqlDataSourceBuilder("Host=localhost;Database=testdb;Username=zizheng;Password=");

// Doesn't work:
dataSourceBuilder.MapEnum<MyEnum>();

// Works:
// NpgsqlConnection.GlobalTypeMapper.MapEnum<MyEnum>();

await using var dataSource = dataSourceBuilder.Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
{
    _ = options.UseNpgsql(dataSource);
});
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
