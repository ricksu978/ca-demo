using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class PlayerJoinGameRequest
    {
        public int GameId { get; set; }
        public int PlayerId { get; set; }
    }

    public class PlayerJoinGameUseCase
    {
        private readonly IRepository _repository;

        public PlayerJoinGameUseCase(IRepository repository)
        {
            _repository = repository;
        }

        public void Execute(PlayerJoinGameRequest request)
        {
            // 查
            var game = _repository.FindById(request.GameId);

            // 改
            game.PlayerJoin(request.PlayerId);

            // 存
            _repository.Save(game);

            // 推
            // Presenter
        }
    }
}
