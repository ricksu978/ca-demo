namespace Domain.Entities
{
    // 聚合跟
    public class Game
    {
        public int Id { get; set; }

        public ICollection<Player> Players { get; set; } = new HashSet<Player>();

        public void PlayerJoin(int playerId)
        {
            // 維護 domain invariants
            if(Players.Count >= 12)
            {
                throw new Exception("Too many players");
            }

            Players.Add(new Player() { Id = playerId });
        }
    }
}