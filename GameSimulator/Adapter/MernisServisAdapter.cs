using GameSimulator.Entities.Concrete;
using GameSimulator.MernisServisReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Adapter
{
    public class MernisServisAdapter : ICheckIfRealPerson
    {

        public bool IsRealPerson(Customer customer)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient();
            return kPSPublicSoapClient.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId),
                customer.CustomerFirstName, 
                customer.CustomerLastName, 
                customer.DateofBirth.Year);
        }
    }
}
