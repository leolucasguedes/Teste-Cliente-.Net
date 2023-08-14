using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using WebApi.Data;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            DotNetEnv.Env.Load();
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = $"Host={Env.GetString("DB_HOST")};Port={Env.GetString("DB_PORT")};Database={Env.GetString("DB_NAME")};Username={Env.GetString("DB_USER")};Password={Env.GetString("DB_PASSWORD")};";
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowReactApp",
                    builder => builder
                        .WithOrigins("http://localhost:3000", "http://localhost:3001")  // Ou a origem do seu aplicativo React
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                );
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minha API", Version = "v1" });
            });

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString,
                postgresOptions => postgresOptions.MigrationsAssembly("TesteDotNet")));

            services.AddScoped<AppDbContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1"));
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowReactApp");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

