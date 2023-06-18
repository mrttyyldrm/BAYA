using BAYA.Core.Entities;
using BAYA.Core.Repositories;
using BAYA.Core.Services;
using BAYA.Core.UnitOfWorks;
using BAYA.Repository.Context;
using BAYA.Repository.Repositories;
using BAYA.Repository.UnitOfWorks;
using BAYA.Service.Mapping;
using BAYA.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddAutoMapper(typeof(MapProfile));


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IAidNoticeRepository, AidNoticeRepository>();
builder.Services.AddScoped<IAidNoticeService, AidNoticeService>();
builder.Services.AddScoped<ICountyRepository, CountyRepository>();
builder.Services.AddScoped<ICountyService, CountyService>();

builder.Services.AddScoped<IHelpCenterRepository, HelpCenterRepository>();
builder.Services.AddScoped<IHelpCenterService, HelpCenterService>();

builder.Services.AddScoped<IAdminsRepository, AdminsRepository>();
builder.Services.AddScoped<IAdminsService, AdminsService>();

builder.Services.AddScoped<IStreetService, StreetService>();
builder.Services.AddScoped<IStreetRepository, StreetRepository>();
builder.Services.AddScoped<IDistrictService, DistrictService>();
builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();

//Db created
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerDbContext"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});


// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("BAYACors", opt =>
    {
        opt.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("BAYACors");

app.UseAuthorization();

app.MapControllers();

app.Run();
