using GameSimulator.Business.Abstract;
using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Customer customer, Game game, Campaign campaign)
        {
            double NewGamePrice = game.GamePrice * campaign.CampaignRate;
            Console.WriteLine("{0} adlı kişiye {1} adlı oyun {2} kampanyası ile {3} TL'ye satılmıştır.", customer.CustomerFirstName, game.GameName, campaign.CampaignName, NewGamePrice);
        }

        public void Sale(Customer customer, Game game)
        {

            Console.WriteLine("{0} adlı kişiye {1} adlı oyun {3} TL'ye satılmıştır.", customer.CustomerFirstName, game.GameName);

        }

        public void ToReturn(Customer customer, Game game, string ReasonOfReturn)
        {
            Console.WriteLine("{0} adlı kişi tarafından {1} adlı oyun iade edilmiştir.", customer.CustomerFirstName, game.GameName);
        }
    }
}
