using DevelopersPodcast.Application.Episodes;
using DevelopersPodcast.Infrastructure.Transistor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevelopersPodcast.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPodcastDistributor(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(new TransistorSettings(configuration["Transistor:ApiKey"], configuration["Transistor:BaseUrl"]));
            services.AddTransient<IEpisodesService, EpisodesService>();
        }
    }
}