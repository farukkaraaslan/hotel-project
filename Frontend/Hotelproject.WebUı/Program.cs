using FluentValidation;
using FluentValidation.AspNetCore;
using Hotelproject.WebUI.Areas.Admin.Models.Room;
using Hotelproject.WebUI.Areas.Admin.Models.Rules.ValidaitonRules.Room;
using HotelProject.DataAccess.Concrete;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProjectContext>();
builder.Services.AddTransient<IValidator<AddRoomModel>, RoomAddValidaitor>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapAreaControllerRoute(
        name: "Areas",
        areaName: "Admin",
        pattern: "admin/{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
