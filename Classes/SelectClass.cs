using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TreningRPG.Classes;
using TreningRPG.VisualInterface;

namespace TreningRPG
{
    internal class SelectClass
    {
        
        internal void EnterClass()
        {      
            Console.WriteLine("Enter name");

            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Select class\n1: Warior\t2: Assasin");

            int selectClass = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            Greetings greetings = new Greetings();
            HeroPanel heroPanel = new HeroPanel();

            Console.Clear();
            greetings.GreetingHero();
            Console.WriteLine();
            heroPanel.UpPanel();
            
            switch (selectClass)
            {
                case 1:
                    Warior warior = new Warior();
                    warior.name = name;
                    warior.classRPG = "Warior";
                    warior.damage = random.Next(15,25);
                    warior.armor = random.Next(25,35);
                    warior.PrintCharacter();
                    break;
                case 2:
                    Assasin assasin = new Assasin();
                    assasin.name = name;
                    assasin.classRPG = "Assasin";
                    assasin.damage = random.Next(25,35);
                    assasin.armor = random.Next(15, 20);
                    assasin.PrintCharacter();
                    break;

            }


        }

    }
}
