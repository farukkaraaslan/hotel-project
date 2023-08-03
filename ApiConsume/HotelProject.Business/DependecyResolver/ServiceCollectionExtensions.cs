using HotelProject.Business.Abstract;
using HotelProject.Business.Concrete;
using HotelProject.Business.Rules.Validaiton;
using HotelProject.Core.Helpers.FileHelper;
using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.EntityFramework;
using HotelProject.Dto;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.DependecyResolver;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterBusinessService(this IServiceCollection services )
    {
        services.AddDbContext<ProjectContext>()
            .AddAutoMapper(typeof(AutoMapperConfig))
        .AddScoped<IStaffDal, EfStaffDal>()
        .AddScoped<IStaffService, StaffManager>()

        .AddScoped<IServiceDal, EfServiceDal>()
        .AddScoped<IServiceService, ServiceManager>()

        .AddScoped<ITestimonialDal, EfTestimonialDal>()
        .AddScoped<ITestimonialService, TestimonialManager>()
        .AddScoped<TestimonialValidator>()

        .AddScoped<ISubscribeDal, EfSubscribeDal>()
        .AddScoped<ISubscribeService, SubscribeManager>()

        .AddScoped<IRoomDal, EfRoomDal>()
        .AddScoped<IRoomService, RoomManager>()
        .AddScoped<RoomValidator>()

        .AddScoped<IAboutDal, EfAboutDal>()
        .AddScoped<IAboutService, AboutManager>()

        .AddScoped<IBookingDal, EfBookingDal>()
        .AddScoped<IBookingService, BookingManager>()

        .AddScoped<IContactDal, EfContactDal>()
        .AddScoped<IContactService, ContactManager>()

        .AddScoped<IFileHelper, FileHelper>();
        return services ;
    }
}
