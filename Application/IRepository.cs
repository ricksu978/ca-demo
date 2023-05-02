using Domain.Entities;

namespace Application
{
    public interface IRepository
    {
        public Game FindById(int id);
        public void Save(Game game);
    }
}
