using Contracts;
using LoggerService;
using NLog;

namespace RestFullAPI.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    ;
                });

            });
        }

        public static void ConfigureNlog(this IServiceCollection services, string env)
        {
            LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), $"/nlog.{env}.config"));
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
