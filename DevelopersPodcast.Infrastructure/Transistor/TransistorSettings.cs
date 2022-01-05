namespace DevelopersPodcast.Infrastructure.Transistor
{
    public class TransistorSettings
    {
        public string ApiKey { get; }

        public string BaseUrl { get; }

        public TransistorSettings(string apiKey, string baseUrl)
        {
            ApiKey = apiKey;
            BaseUrl = baseUrl;
        }
    }
}