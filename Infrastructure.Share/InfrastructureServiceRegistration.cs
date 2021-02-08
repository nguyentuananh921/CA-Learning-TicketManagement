using Application.Contracts.Infrastructure;
using Application.Models.Mail;
using Infrastructure.Share.FileExport;
using Infrastructure.Share.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//Microsoft.Extensions.Options.ConfigurationExtensions
namespace Infrastructure.Share
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            

            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
