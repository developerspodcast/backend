using System;

namespace DevelopersPodcast.Application.Episodes
{
    public class Episode
    {
        public string Title { get; set; }
        public int EpisodeNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageUrl { get; set; }
        public string MediaUrl { get; set; }
    }
}