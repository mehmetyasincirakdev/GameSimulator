using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Adapter
{
    public interface ICheckIfRealPerson
    {
        bool IsRealPerson(Customer customer);
    }
}
