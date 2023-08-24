namespace SOLID.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bird penguin = new Bird();
            Console.WriteLine("Penguin");
            penguin.Chirp();

            Console.WriteLine("Ostrich");
            Ostrich ostrich = new Ostrich();
            ostrich.Chirp();

            Console.WriteLine("Pigeon");
            Pigeon pigeon = new Pigeon();
            pigeon.Chirp();
            pigeon.Fly();
        }
    }
}