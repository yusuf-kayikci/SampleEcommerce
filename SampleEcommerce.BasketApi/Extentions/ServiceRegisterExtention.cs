﻿using Microsoft.Extensions.DependencyInjection;
using SampleEcommerce.Business.Services;
using SampleEcommerce.Core.Abstractions;
using SampleEcommerce.Data.DbConnection;
using SampleEcommerce.Data.Entity;
using SampleEcommerce.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEcommerce.BasketApi.Extentions
{
    public static class ServiceRegisterExtention
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IMongoConnectionProvider, MongoConnectionProvider>();
            //Generic dependency injenction
            services.AddSingleton<IRepository<Basket> , BasketRepository>();
            services.AddSingleton<IService<Basket>, BasketService>();
            
        }

    }
}
