using GameSimulator.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Entities.Concrete
{
    public class Game:IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string TypeOfGame { get; set; }
        public double GamePrice { get; set; }

    }
}
