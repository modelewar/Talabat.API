using Microsoft.EntityFrameworkCore;
using Talabat.Repository.Data;

namespace Talabat.APIs
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Configer Services & Services to the Container 
             //
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

            });


            #endregion
            var app = builder.Build();
            #region Update-Database
             
            //StoreContext dbContext = new StoreContext(); //Invalide
            //await dbContext.Database.MigrateAsync();

            using var Scope = app.Services.CreateScope();
            //Group Of Services LifeTime Scooped
            var Services = Scope.ServiceProvider;
            //Services ItSelf
            var dbContext = Services.GetRequiredService<StoreContext>();
            //Ask CLR For Creating Object from DbContext Explicitly 
            await dbContext.Database.MigrateAsync(); //Update Database
            #endregion

            #region // Configure the HTTP request pipeline.MiddelWars
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            #endregion
            app.Run();  
            

        }
    }
}
