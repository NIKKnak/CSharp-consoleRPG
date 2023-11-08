using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG
{
    internal class MainClass
    {
        internal string name { get; set; }
        internal string classRPG { get; set; }
        internal int armor { get; set; }
        internal int damage { get; set; }

        internal MainClass()
        {
            string Name = name;
            string ClassRPG = classRPG;
            int Armor = armor;
            int Damage = damage;
        }

        internal void PrintCharacter()
        {
            Console.WriteLine($"Name: {name} Class: {classRPG} Armor: {armor} Damage: {damage}");
        }



    }
}
