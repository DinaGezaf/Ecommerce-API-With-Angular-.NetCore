
using AutoMapper;
using Ecommerce.API.Middlewares;
using Ecommerce.BL;
using Ecommerce.BL.Helpers;
using Ecommerce.BL.Managers.Product_Manager;
using Ecommerce.DAL;
using Ecommerce.DAL.Data.Context;
using Ecommerce.DAL.Repos.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("ECom", p => p.AllowAnyHeader().AllowAnyOrigin().WithOrigins("http://localhost:4200"));
            });
            #region Database
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<StoreContext>(
                options => options.UseSqlServer(connectionString));

            #endregion

            #region Repos
            builder.Services.AddScoped<IProductRepo, ProductRepo>();

            #endregion
            #region Managers

            builder.Services.AddScoped<IProductManager, ProductManager>();
            builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseRouting();
            app.UseCors("ECom");
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseStatusCodePagesWithReExecute("errors/{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCors("ECom");
            app.UseAuthorization();
            using  var scope=app.Services.CreateScope();
            var services=scope.ServiceProvider;
            var context=services.GetRequiredService<StoreContext>();
            var logger = services.GetRequiredService<ILogger<Program>>();

            try
            {
                context.Database.MigrateAsync();
            }
            catch(Exception ex)
            {
                logger.LogError(ex, "Error occured while migrating process");
            }
            app.MapControllers();

            app.Run();
        }
    }
}