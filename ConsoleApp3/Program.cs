using System.Reflection.Emit;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MysteryBox Newbox = new MysteryBox("fra alle mig, til alle dig", "goldcoins", true);

            Console.WriteLine(Newbox);

        }
    }
}
