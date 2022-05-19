using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PlayerModel : IPlayerModel
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid Id { get { return _id; } }
        public string Name { get; set; }
        public delegate void PrintPlayerInfo(PlayerModel p);
        public PlayerModel() { }
        public PlayerModel(string name)
        {
            Name = name;
        }
        public void Print(PrintPlayerInfo printPlayer, PlayerModel Player)
        {
            printPlayer(player);
        }
    }
}
