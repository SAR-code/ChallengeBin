namespace VirtualATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount dylansAccount = new BankAccount("1111-2222-3333-4444", 100000, 7912);
            
            int pin;
            int choice;
            double withdraw;
            double deposit;
            double amount;

            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Insert your pin number");
            pin = int.Parse(Console.ReadLine());

            if (pin == dylansAccount.Pin)
            {
                Console.WriteLine("Welcome Dylan");
            } 
            else
            {
                Console.WriteLine("You have entered an invalid pin");
            }
            while (true)
            {
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is {dylansAccount.AccountBalance}");
                        break;
                    case 2:
                        Console.WriteLine("Please enter an amount to withdraw");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("Enter an amount over 100");
                        } else if (withdraw > ( dylansAccount.AccountBalance - 500))
                        {
                            Console.WriteLine("Insufficient funds");
                        } else
                        {
                            amount = dylansAccount.AccountBalance - withdraw;
                            Console.WriteLine($"Here is your cash. Your remaining balance is ${amount}");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter a deposit amount");
                        deposit = int.Parse(Console.ReadLine());
                        amount = dylansAccount.AccountBalance + deposit;
                        Console.WriteLine("Your amount has been deposited");
                        Console.WriteLine("Your total balance is ${0}", amount);
                        break; 
                    case 4:
                        Console.WriteLine("Thank you, come again");
                        return;
                        
                }
                Console.WriteLine("Thank you");
            }

            
            
            
        }
    }
}