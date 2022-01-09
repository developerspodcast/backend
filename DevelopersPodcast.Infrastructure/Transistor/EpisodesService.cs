using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopersPodcast.Application.Episodes;
using RestEase;

namespace DevelopersPodcast.Infrastructure.Transistor
{
    public class EpisodesService : IEpisodesService
    {
        private readonly ITransistorApi _api;
        
        public EpisodesService(TransistorSettings settings)
        {
            _api = RestClient.For<ITransistorApi>(settings.BaseUrl);
            _api.ApiKey = settings.ApiKey;
        }
        
        public async Task<IEnumerable<Episode>> GetEpisodes()
        {
            EpisodeResponse response;
            
            try
            {
                response = await _api.GetEpisodes();
            }
            catch (ApiException e)
            {
                throw new Exception();
            }

            return response.Data.Select(Map);
        }

        private static Episode Map(Data episode)
        {
            return new Episode
            {
                Description = episode.Attributes.Description,
                Title = episode.Attributes.Title,
                EpisodeNumber = episode.Attributes.Number,
                ImageUrl = episode.Attributes.Image_Url,
                MediaUrl = episode.Attributes.Media_Url,
                PublishDate = episode.Attributes.Published_At,
                EmbedCode = episode.Attributes.Embed_Html_Dark,
            };
        }
    }
}