using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.NewtonsoftJson;
using IntroGraphQL.Database;
using IntroGraphQL.GraphQL;
using IntroGraphQL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Web.Mvc;

namespace IntroGraphQL
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
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(
                    Configuration["ConnectionString"]), ServiceLifetime.Transient);
            services.AddTransient<Func<ApplicationDbContext>>(options => () => options.GetService<ApplicationDbContext>());
            services.AddTransient<BooksRepository>();
            services.AddTransient<AuthorsRepository>();

            //services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(
            //    s.GetRequiredService));
            services.AddScoped<LibrarySchema>();


            services.AddGraphQL(o => { o.EnableMetrics = true; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { })
                .AddDataLoader();

            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseGraphQL<LibrarySchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());

            dbContext.Seed();
        }
    }
}
