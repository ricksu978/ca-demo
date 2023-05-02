using Application;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFRepository
{
    public class EFRepository : DbContext, IRepository
    {
        public Game FindById(int id)
        {
            return Set<Game>().First(x => x.Id == id);
        }

        public void Save(Game game)
        {
            Add(game); // or Update(game);

            SaveChanges();
        }
    }
}