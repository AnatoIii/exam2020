using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services;
using BLL.Services.Abstractions;
using DAL;
using DAL.Repositories;
using DAL.Repositories.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
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
			services.AddControllers();

			services.AddTransient<IDepartmentService, DepartmentService>();
			services.AddTransient<IProductService, ProductService>();

			services.AddTransient<IDepartmentProductsRepository, DepartmentProductsRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
			services.AddTransient<IDepartmentRepository, DepartmentRepository>();

			services.AddDbContext<ShopDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ShopDbContext")));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseCors(builder => builder
										.AllowAnyOrigin()
										.AllowAnyMethod()
										.AllowAnyHeader());

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints => {
				endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
