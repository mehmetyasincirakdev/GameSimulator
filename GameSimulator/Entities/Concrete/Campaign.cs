using GameSimulator.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Entities.Concrete
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDuration { get; set; }
        public double CampaignRate { get; set; }
    }
}
