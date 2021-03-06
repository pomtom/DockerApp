﻿using DockerBusiness.Service;
using DockerDB.Models;
using DockerDB.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DockerApp
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
            // Add framework services.

            //services.AddDbContext<e2eContext>(options =>
            //    options.UseSqlServer(@"Server=DESKTOP-C9GMV6E\SQLEXPRESS;Database=e2e;Trusted_Connection=True;"));

            services.AddMvc();

            var appSettings = Configuration.GetSection("ConnectionStrings");
            services.Configure<AppSettings>(appSettings);

            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
