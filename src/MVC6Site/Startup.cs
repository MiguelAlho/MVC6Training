﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using MVC6Site.Repositories;
using MVC6Site.Models;

namespace MVC6Site
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IRepository<CellViewModel>, InMemoryCellRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
                routes.MapRoute(
                    "default",  
                    "{controller}/{action}/{id?}", 
                    new { Controller = "Home", Action ="Index"}
                )
            );
        }
    }
}
