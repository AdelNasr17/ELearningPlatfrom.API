
using ELearningPlatfrom.Infrastructure.Persistence.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ELearningPlatfrom.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            #region  Add services to the container.
            builder.Services.AddControllers(); // Adds services for controllers to the DI container

            // Learn more about configuring Swagger/OpenAPI 
            builder.Services.AddEndpointsApiExplorer(); // Adds support for API endpoint exploration
            builder.Services.AddSwaggerGen(); // Adds Swagger generation for API documentation

            // Configure the DbContext to use SQL Server with the connection string from configuration
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")); // Use SQL Server with the specified connection string
            });

            #endregion
            var app = builder.Build(); // Build the application

            #region  Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger(); // Enable Swagger in development mode
                app.UseSwaggerUI(); // Enable the Swagger UI
            }

            app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
            app.UseAuthorization(); // Enable authorization middleware

            app.MapControllers(); // Map attribute-routed controllers

            app.Run(); // Run the application 
            #endregion
        }
    }
}
