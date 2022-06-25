using Microsoft.EntityFrameworkCore;
using System.Reflection;
using w2homework.Repository;
using w2homework.Repository.IRepositories;
using w2homework.Repository.Repositories;
using w2homework.Service.IServices;
using w2homework.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Db için context tanýmý yapýldý ve connection string (appsettings.json içerisinde) adresi gösterildi
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

//Interface'lerle class'lar eþlendi

builder.Services.AddScoped<IAdminService, AdminService>();

builder.Services.AddScoped<IBootcampRepository, BootcampRepository>();
builder.Services.AddScoped<IBootcampService, BootcampService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

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
