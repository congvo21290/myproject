using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lightStore_API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace lightStore_API
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
      // Web API configuration and services

      services.AddSingleton(Configuration);

      services.AddDbContext<LightStoreDbContext>(options => options.
       UseMySQL(Configuration.GetConnectionString("connect")),
         ServiceLifetime.Scoped);








      //Closing database connections
      /*To free up the resources that a database connection holds,
       * the context instance must be disposed as soon as possible when you are done with it. 
       * The ASP.NET Core built-in dependency injection takes care of that task for you.

      In Startup.cs, you call the AddDbContext extension method to provision the DbContext class in the ASP.NET DI container.
      That method sets the service lifetime to Scoped by default.
      Scoped means the context object lifetime coincides with the web request life time, 
      and the Dispose method will be called automatically at the end of the web request.*/

      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
