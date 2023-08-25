using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Warrior : IHeal, IFlee, IGuard
    {
        

        public string name;
        public string weapon;
        public string shield;

        private string item;

        // Overloading Constructors
        public Warrior() { }

        public Warrior(string name, string weapon)
        {
            this.name = name;
            this.weapon = weapon;

           
        }

        public Warrior(string name, string weapon, string shield)
        {
            this.name = name;
            this.weapon = weapon;
            this.shield = shield;

        }

        
        // Utilizing a getter and setter
        public string Item
        {
            get { return item; } 
            set 
            {
                if ( value != "potion")
                {
                    Console.WriteLine($"You cannot use {value} in battle");
                } else
                {
                    Console.WriteLine($"{name} used a {value} and healed 300Hp");
                    item = value;
                }
                
            }
        }

        //invoking functions/interfaces
        public void Engage()
        {
            Console.WriteLine($"{name} strikes with their {weapon}!");
        }

        public void Heal()
        {
            Console.WriteLine($"{name} has healed themselves with an item");
        }

        public void Flee()
        {
            Console.WriteLine($"{name} was outmatched and fled from the battle");
        }

        public void Guard()
        {
            if (shield != null )
            {
                Console.WriteLine($"{name} blocks and attack with their {shield}");
            } else
            {
                Console.WriteLine($"{name} is unable to block an attack");
            }
        }
    }

    //Utilizing Interfaces
    interface IGuard
    {
        void Guard();
    }

    interface IHeal
    {
        void Heal();
    }

    interface IFlee
    {
        void Flee();
    }

    interface ISwim
    {
        void Swim();
    }

   public class Berserker : Warrior
    {
        private string ability = "Raging Blow";

        public Berserker(string name, string weapon)
        {
            this.name = name;
            this.weapon = weapon;
            
        }

        public string Ability
        {
            get { return this.ability; }
            
        }

        public void Swim()
        {
            Console.WriteLine("{0} has the hidden swim ability to traverse bodies of water", name);
        }
    }
}
