using GameSimulator.Adapter;
using GameSimulator.Business.Concrete;
using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            gameManager.Add(new Entities.Concrete.Game
            {
                GameId = 1,
                GameName = "Euro Truck Simulator 2",
                TypeOfGame = "Driving",
                GamePrice = 20
            });
            CampaignManager campaignManager = new CampaignManager();
            CustomerManager customerManager = new CustomerManager(new MernisServisAdapter());
            customerManager.Add(new Entities.Concrete.Customer
            {
                CustomerId = 1,
                CustomerFirstName = "Mehmet Yasin",
                CustomerLastName = "Çirak",
                DateofBirth = new DateTime(1996, 08, 11),
                NationalityId = "5456789"
            });
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(new Entities.Concrete.Customer
            {
                CustomerId = 1,
                CustomerFirstName = "Mehmet Yasin",
                CustomerLastName = "Çir",
                DateofBirth = new DateTime(1996, 08, 11),
                NationalityId = "212311232"
            }
            , new Entities.Concrete.Game
            {
                GameId = 1,
                GameName = "Euro Truck Simulator 2",
                TypeOfGame = "Driving",
                GamePrice = 150
            }
            ,
            new Entities.Concrete.Campaign
            {
                CampaignId = 1,
                CampaignName = "Black Friday",
                CampaignRate = 0.50,
                CampaignDuration = "1 Ay"
            });
            Console.ReadLine();
        }
    }
}
