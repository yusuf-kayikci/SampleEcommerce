using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SampleEcommerce.BasketApi.Middleware;
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
    public static class StartupException
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IMongoConnectionProvider, MongoConnectionProvider>();
            //Generic dependency injenction
            services.AddSingleton<IBasketRepository , BasketRepository>();
            services.AddSingleton<IBasketService, BasketService>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductService, ProductService>();

        }


        public static void UseMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }

    }
}
