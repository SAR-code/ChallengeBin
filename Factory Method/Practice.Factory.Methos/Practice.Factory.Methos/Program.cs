

namespace Practice.Factory.Methos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Titanium");

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : {0}", cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : {0}", cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge : {0}", cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }


            Console.ReadLine();
        }
    }
}