using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerPOO
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + Price * (decimal)Tax;
        }
        public override string? ToString()
        {
            return $"{Id}" +
               $"{Description} " +
               $"Price: {Price}, " +
               $"Tax: {Tax}, " +
               $"Value: {ValueToPay()}";
        }
    }
}
