using System.Threading.Channels;
using TreningRPG.Classes;

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
            selectClass.EnterClass();
            SkeletonVarior skeletonVarior = new SkeletonVarior();

            

        }
        
    }
}