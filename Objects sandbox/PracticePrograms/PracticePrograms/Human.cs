using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Human
    {
        public string Name;
        public int Age;

        public void Eat(string food) { 
            Console.WriteLine("\n{0} ate some {1} for a quick snack!", this.Name, food);
        }
        
    }


    public class Runner : Human 
    {
        public void Sprint(int dist)
        {
            Console.WriteLine("\n{0} competes in the {1}m within his age group of {2}", this.Name, dist, this.Age);
        }
    }

    public class Swimmer : Runner
    {
        public void Swim(int dist)
        {
            Console.WriteLine("\n{0} swims {1}m on their cardio days", this.Name, dist);
        }
    }






}
