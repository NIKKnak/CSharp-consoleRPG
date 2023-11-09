using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreningRPG.Classes
{
    internal class Assasin : MainClass
    {

        internal void PrintCharacter()
        {
            Console.WriteLine($"Name: {name} Class: {classRPG} Armor: {armor} Damage: {damage}");
        }
    }
}
