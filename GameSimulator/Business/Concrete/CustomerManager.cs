using GameSimulator.Adapter;
using GameSimulator.Business.Abstract;
using GameSimulator.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
       private ICheckIfRealPerson _checkIfRealPerson;

        public CustomerManager(ICheckIfRealPerson checkIfRealPerson)
        {
            _checkIfRealPerson = checkIfRealPerson;
        }

        public void Add(Customer entity)
        {
            if (_checkIfRealPerson.IsRealPerson(entity))
            {
                Console.WriteLine("Müşteri başarıyla eklendi. {0}", entity.CustomerFirstName);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }

        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("Müşteri başarıyla silindi. {0}", entity.CustomerFirstName);
        }

        public void Update(Customer entity)
        {
            Console.WriteLine("Müşteri başarıyla güncellendi. {0}", entity.CustomerFirstName);
        }
    }
}
