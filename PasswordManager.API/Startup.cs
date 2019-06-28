using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PasswordEncryptor.Implementation;
using PasswordEncryptor.Interfaces;
using PasswordManager.Core.Entities;
using PasswordManager.Core.Interfaces;
using PasswordManager.Core.Services;
using PasswordManager.Infrastructure;

namespace PasswordManager.API
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connection = "Data Source=DESKTOP-CLC7U5P\\SQLEXPRESS;Initial Catalog=PasswordManagerDev;Integrated Security=True";
            services.AddDbContext<PasswordManagerDbContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IUsersService, UsersService>();
            //services.AddTransient<IPasswordManagerService, PasswordManagerService>();

            services.AddTransient<IUserRepository, UsersRepository>();

            services.AddTransient<IRepository<Users>, Repository<Users>>();
            services.AddTransient<IRepositoryAsync<Users>, RepositoryAsync<Users>>();

            services.AddSingleton<ISimplePasswordEncryption<Users>, SimplePasswordEncryption<Users>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");

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
