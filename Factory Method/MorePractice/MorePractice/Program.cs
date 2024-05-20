using System.Collections;

namespace MorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Novice soldierOne = new Novice("Dylan", 31);
            soldierOne.speak($"My name is {soldierOne.Name}, I am {soldierOne.Age} years old, I am a Novice");
            soldierOne.Slash("Knife");

            Swordsman soldierTwo = new Swordsman("Chrom", 30);
            soldierTwo.speak($"My name is {soldierTwo.Name}, I am {soldierTwo.Age} years old, I am a Swordman");
            soldierTwo.Slash("Sword");
            soldierTwo.Parry("knife");
            soldierTwo.Guard();

            Archer soldierThree = new Archer("Will", 25, "CrossBow");
            soldierThree.Doubleshot();
            
            Hashtable levelParty = new Hashtable();

            levelParty.Add(soldierOne.Name, soldierOne);
            levelParty.Add(soldierTwo.Name, soldierTwo);
            levelParty.Add(soldierThree.Name, soldierThree);

            Swordsman storedSwordsman = (Swordsman)levelParty[soldierTwo.Name];


            
            Console.WriteLine("Name: {0}, Class:Swordsman, Age: {1}", storedSwordsman.Name, storedSwordsman.Age);

            Console.ReadLine();
        }
    }

    public class Novice : ISlash
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Novice(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public void speak(string speak) 
        {
            Console.WriteLine(speak);
        }

        public void Slash(string weapon)
        {
            Console.WriteLine($"{this.Name} used his {weapon} to slash the opponent");
        }

    }

    public class Swordsman : Novice, IParry, IGuard
    {
        public string Shield { get; set; }
        public Swordsman(string name, int age) : base(name, age)
        {
            this.Name= name;
            this.Age = age;
        }

        public Swordsman(string name, int age, string shield) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Shield = shield;
        }

        public new void Slash(string weapon)
        {
            Console.WriteLine($"{this.Name} used his {weapon} to slash the opponent");
        }

        public void Parry(string weapon)
        {
            if (weapon == "sword")
            {
                Console.WriteLine($"{this.Name} parried the attack successfully with their {weapon}!");
            } else
            {
                Console.WriteLine($"{this.Name} cannot parry with their {weapon}!");
            }
        }

        public void Guard()
        {
            if(Shield != null)
            {
                Console.WriteLine($"{this.Name} successfully blocked the attack with their {Shield}");
            } else
            {
                Console.WriteLine($"{this.Name} does not have a shield equipped");
            }
        }

    
    }

    public class Archer : Novice, IDoubleshot
    {
        public string Bow {get; set;}
        public Archer(string name, int age, string bow) : base(name,age)
        {
            this.Name = name;
            this.Age = age;
            this.Bow = bow;
        }

        public void Doubleshot()
        {
            Console.WriteLine($"{this.Name} fires two arrows from their {this.Bow}");
        }
    }

    interface ISlash
    {
        void Slash(string weapon);
    }

    interface IParry
    {
        void Parry(string weapon);
    }

    interface IGuard
    {
        void Guard();
    }

    interface IDoubleshot
    {
        void Doubleshot();
    }


}