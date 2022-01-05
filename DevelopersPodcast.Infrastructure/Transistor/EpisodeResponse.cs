using System;
using System.Collections.Generic;

namespace DevelopersPodcast.Infrastructure.Transistor
{
    public class EpisodeResponse
    {
        public IEnumerable<Data> Data { get; set; }
        public Meta Meta { get; set; }
    }

    public class Data
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public Attributes Attributes { get; set; }
    }

    public class Attributes
    {
        public string Title { get; set; }
        public int Number { get; set; }
        public DateTime Published_At { get; set; }
        public string Media_Url { get; set; }
        public string Image_Url { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
    }

    public class Meta
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
    }
}