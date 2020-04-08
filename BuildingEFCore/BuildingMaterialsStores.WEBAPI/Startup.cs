using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using BuildingMaterialsStores.DAL.Entities;
using BuildingMaterialsStores.DAL.Interfaces;
using BuildingMaterialsStores.DAL.Interfaces.IEntityRepositories;
using BuildingMaterialsStores.DAL.Interfaces.IEntityServices;
using BuildingMaterialsStores.DAL.Repositories.EntityRepositories;
using BuildingMaterialsStores.DAL.Services;
using BuildingMaterialsStores.DAL.UnitOfWork;
using BuildingMaterialsStores.DAL;
using Microsoft.EntityFrameworkCore;

namespace BuildingMaterialsStores.WEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<BuildContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            services.AddDbContext<BuildContext>(opts => opts.UseSqlServer(MyConnection.Connection));
            services.AddControllers();

            #region Repositories
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IStocksRepository, StocksRepository>();
            services.AddTransient<IStoresRepository, StoresRepository>();
            services.AddTransient<IStreetsRepository, StreetsRepository>();
            #endregion

            #region Services
            services.AddTransient<IProductsService, ProductsService>();
            services.AddTransient<IStocksService, StocksService>();
            services.AddTransient<IStoresService, StoresService>();
            services.AddTransient<IStreetsService, StreetsService>();
            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
