using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RentACarAPI.Application.Repositories.BrandRepositories;
using RentACarAPI.Application.Repositories.CarRepositories;
using RentACarAPI.Application.Repositories.CategoryRepositories;
using RentACarAPI.Application.Repositories.ColorRepositories;
using RentACarAPI.Application.Repositories.CustomerRepositories;
using RentACarAPI.Application.Repositories.OrderRepositories;
using RentACarAPI.Persistance.Contexts;
using RentACarAPI.Persistance.Repositories.BrandRepositories;
using RentACarAPI.Persistance.Repositories.CarRepositories;
using RentACarAPI.Persistance.Repositories.CategoryRepositories;
using RentACarAPI.Persistance.Repositories.ColorRepositories;
using RentACarAPI.Persistance.Repositories.CustomerRepositories;
using RentACarAPI.Persistance.Repositories.OrderRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarAPI.Persistance
{
    public static class ServiceRegretion
    {
        public static void Services(this IServiceCollection services)
        {
            services.AddDbContext<RenACarDbContext>(options => options
            .UseNpgsql(Configurations.Configuration.ConnectionString) , ServiceLifetime.Scoped);

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<IBrandReadRepository, BrandReadRepository>();
            services.AddScoped<IBrandWriteRepository, BrandWriteRepository>();
            services.AddScoped<ICarReadRepository, CarReadRepository>();
            services.AddScoped<ICarWriteRepository, CarWriteRepository>();
            services.AddScoped<IColorReadRepository, ColorReadRepository>();
            services.AddScoped<IColorWriteRepository, ColorWriteRepository>();
        }
    }
}
