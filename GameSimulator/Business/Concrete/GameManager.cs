using GameSimulator.Business.Abstract;
using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game entity)
        {
            Console.WriteLine("Oyun başarıyla eklendi. {0}", entity.GameName);
        }

        public void Delete(Game entity)
        {
            Console.WriteLine("Oyun başarıyla silindi. {0}", entity.GameName);
        }

        public void Update(Game entity)
        {
            Console.WriteLine("Oyun başarıyla güncellendi. {0}", entity.GameName);
        }
    }
}
