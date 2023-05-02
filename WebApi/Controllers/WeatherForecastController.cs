using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly PlayerJoinGameUseCase _useCase;

        public WeatherForecastController(PlayerJoinGameUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost("~/games/{gameId}/players")]
        public Task PlayerJoinGame(int gameId, PlayerJoinGameRequest request)
        {
            request.GameId = gameId;
            
            _useCase.Execute(request);

            return Task.CompletedTask;
        }
    }
}