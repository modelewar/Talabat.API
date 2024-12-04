<<<<<<< Updated upstream
=======
using Microsoft.EntityFrameworkCore;
using Talabat.Repository;
using Talabat.Repository.Data;
using Talabate.Core.Entites;
using Talabate.Core.Repositories;

>>>>>>> Stashed changes
namespace Talabat.APIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Configer Service
             //
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

<<<<<<< Updated upstream
=======
            });
            //builder.Services.AddScoped<IGenaricRepository<Product>,GenericRepository<Product>>();
            builder.Services.AddScoped(typeof(IGenaricRepository<>), typeof(GenericRepository<>));

            #endregion
>>>>>>> Stashed changes
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run(); 
            #endregion
        }
    }
}
