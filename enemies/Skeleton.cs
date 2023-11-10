using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG
{
    internal class SkeletonVarior : MainClass
    {
        

        private string name { get; init; } = $"Skeleton {RandomName.GetName()}";
        internal string classRPG { get; init; } = "Skeleton varior";
        internal int armor { get; set; } = 10 ;
        internal int damage { get; set; } = 10;
        


        internal void PrintCharacter()
        {
            Console.WriteLine($"Name: {name} Class: {classRPG} Armor: {armor} Damage: {damage}");
        }

    }
}
