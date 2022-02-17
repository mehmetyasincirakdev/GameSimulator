using GameSimulator.Business.Abstract;
using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Kampanya başarıyla eklendi. {0}", entity.CampaignName);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Kampanya başarıyla silindi. {0}",entity.CampaignName);
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Kampanya başarıyla güncellendi. {0}", entity.CampaignName);
        }
    }
}
