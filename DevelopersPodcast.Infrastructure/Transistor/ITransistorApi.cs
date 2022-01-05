using System.Threading.Tasks;
using RestEase;

namespace DevelopersPodcast.Infrastructure.Transistor
{
    public interface ITransistorApi
    {
        [Header("x-api-key")]
        string ApiKey { get; set; }
        
        [Get("episodes?show_id=14671&status=published&pagination[per]=1000")]
        Task<EpisodeResponse> GetEpisodes();
    }
}