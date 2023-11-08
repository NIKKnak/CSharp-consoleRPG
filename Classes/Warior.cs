using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG.Classes
{
    internal class Warior : MainClass
    {

        internal int armor = 30;
        internal int damage = 25;



        internal void PrintCharacter()
        {
            Console.WriteLine($"Name: {name} Class: {classRPG} Armor: {armor} Damage: {damage}");
        }

    }
}
