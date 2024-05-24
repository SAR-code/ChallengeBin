using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Factory.Methos
{
     public abstract class CreditCard : IGetCardType, IGetCreditLimit, IGetAnnualCharge
    {
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
        public abstract int GetAnnualCharge();
    }

    interface IGetCardType
    {
        abstract string GetCardType();
    }

    interface IGetCreditLimit
    {
        abstract int GetCreditLimit();
    }

    interface IGetAnnualCharge
    {
        abstract int GetAnnualCharge();
    }
}
