using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Sample_2
{
    public class Game : PrototypeGame
    {
        public int _PlayerId { get; set; }
        public string _GameName { get; set; }
        public string _GameType { get; set; }
        public bool _isActive { get; set; }

        public Game(int playerId, string gameName, string gameType, bool isActive)
        {
            _PlayerId = playerId;
            _GameName = gameName;
            _GameType = gameType;
            _isActive = isActive;
        }

        public override PrototypeGame Clone()
        {
            return MemberwiseClone() as PrototypeGame;
        }
    }
}
