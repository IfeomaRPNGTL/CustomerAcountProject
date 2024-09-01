
using RpnInnovation.WebApi.Extensions;
using Serilog;
using Serilog.Events;

namespace RpnInnovation.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("microsoft", LogEventLevel.Warning)
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger.Information("logging is working fine");

            var builder = WebApplication.CreateBuilder(args);

            // For logging info
            builder.Host.UseSerilog();

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddRepository(builder);

            builder.Services.AddValidators();
            builder.Services.AddCoreServices();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
