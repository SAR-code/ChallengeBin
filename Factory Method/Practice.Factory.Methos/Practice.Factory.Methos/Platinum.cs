namespace Practice.Factory.Methos
{
    public class Platinum : CreditCard
    {
        public override string GetCardType()
        {
            return "Platinum Plus";
        }

        public  override int GetCreditLimit()
        {
            return 35000;
        }

        public override int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
