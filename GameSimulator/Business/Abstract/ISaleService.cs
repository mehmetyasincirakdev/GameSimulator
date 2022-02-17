using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Business.Abstract
{
    public interface ISaleService
    {
        void Sale(Customer customer, Game game, Campaign campaign);
        void Sale(Customer customer, Game game);
        void ToReturn(Customer customer, Game game, string ReasonOfReturn);
    }
}
