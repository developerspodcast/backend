using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevelopersPodcast.Application.Episodes
{
    public interface IEpisodesService
    {
        Task<IEnumerable<Episode>> GetEpisodes();
    }
}