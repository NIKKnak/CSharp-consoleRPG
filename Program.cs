using System.Runtime.CompilerServices;
using System.Threading.Channels;
using TreningRPG.Classes;
using TreningRPG.Mahanics;

namespace TreningRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Greetings greetings = new Greetings();
            greetings.GreetingsText("sdfsdfdsfds");

            Console.WriteLine();


            Menu menu = new Menu();
            menu.MenuText();

            SelectClass selectClass = new SelectClass();
            MainClass myHero = selectClass.EnterClass() as MainClass;
            myHero.PrintCharacter();


            SkeletonVarior skeletonVarior = new SkeletonVarior();
            skeletonVarior.PrintCharacter();



            Fight fight = new Fight();
            fight.StartBattle((MainClass)myHero, skeletonVarior);




        }

    }
}