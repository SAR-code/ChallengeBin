namespace PracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Warrior knight = new Warrior("Bartre", "Axe");

            knight.Engage();
            knight.Heal();
            knight.Flee();
            knight.Guard();
            knight.Item = "potion";

            

            Warrior crusader = new Warrior("Maximus", "broadsword", "iron shield");
            crusader.Engage();
            crusader.Heal();
            crusader.Flee();
            crusader.Guard();
            crusader.Item = "key";

            List<Warrior> platoonOne = new List<Warrior>(); 

            platoonOne.Add(knight);
            platoonOne.Add(crusader);

            foreach(Warrior warrior in platoonOne)
            {
                Console.WriteLine(warrior.name);
            }



            Berserker pirate = new Berserker("Dart", "Axe");
            pirate.Engage();
            pirate.Flee();

            pirate.Guard();
            pirate.Heal();

            pirate.Swim();
            pirate.shield = "Steel Wall";
            pirate.Guard();

            pirate.Item = "potion";
            string power = pirate.Ability;

            Console.WriteLine($"{pirate.name} has a new ability called {power}");
        }
    }
}