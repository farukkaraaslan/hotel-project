using HotelProject.Business.Abstract;
using HotelProject.Business.Concrete;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProjectContext>();

builder.Services.AddScoped<IStaffDal,EfStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();

builder.Services.AddScoped<IServiceDal,EfServiceDal>();
builder.Services.AddScoped<IServiceService,ServiceManager>();

builder.Services.AddScoped<ITestimonialDal,EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService,TestimonialManager>();

builder.Services.AddScoped<ISubscribeDal,EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService,SubscribeManager>();

builder.Services.AddScoped<IRoomDal,EfRoomDal>();
builder.Services.AddScoped<IRoomService,RoomManager>();

builder.Services.AddCors(opt=>
{
    opt.AddPolicy("HotelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

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
app.UseCors("HotelapiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
