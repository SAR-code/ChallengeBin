using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Demo
{
    public class Bird
    {
        public void Chirp() {
            Console.WriteLine("Chuuuurp");
        }
    }

    public class FlyingBird : Bird 
    {
        public void Fly(){
            Console.WriteLine("This bird is airborne");
        }
    }

    public class Ostrich : Bird
    {

    }

    public class Pigeon : FlyingBird { }
}
