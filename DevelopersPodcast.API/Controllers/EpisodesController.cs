using System.Threading.Tasks;
using DevelopersPodcast.Application.Episodes;
using Microsoft.AspNetCore.Mvc;

namespace DevelopersPodcast.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EpisodesController : ControllerBase
    {
        private readonly IEpisodesService _episodesService;

        public EpisodesController(IEpisodesService episodesService)
        {
            _episodesService = episodesService;
        }
        
        [HttpGet]
        public async Task<IActionResult> ListEpisodes()
        {
            var response = await _episodesService.GetEpisodes();
            return new JsonResult(response);
        }
    }
}