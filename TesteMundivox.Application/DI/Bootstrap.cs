using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMundivox.Repositories;
using TesteMundivox.Repositories.Interface;
using TesteMundivox.UnitOfWork;
using TesteMundivox.UnitOfWork.Interfaces;

namespace TesteMundivox.Application.DI
{
    public static class Bootstrap
    {
        public static void Inject(ref IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UoW>();
            services.AddTransient<ITimeRepository, TimeRepository>();
            services.AddTransient<IJogoRepository, JogoRepository>();
        }
    }
}
