﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace TreningRPG
{
    internal class SkeletonVarior : MainClass
    {
        


        private string name { get; init; }
        internal string classRPG { get; init; }
        internal int armor { get; set; } 
        internal int damage { get; set; } 
        internal int health { get; set; }

        internal SkeletonVarior(string Name = "Skeleton" , string ClassRPG = "Skeleton varior", int Armor = 10, int Damage = 10, int Health = 50) : base("",  ClassRPG,  Armor,  Damage,  Health)
        {
            RandomName randomName = new RandomName();
            
            this.name = randomName.GetName();
            this.classRPG = ClassRPG;
            this.armor = Armor;
            this.damage = Damage;
            this.health = Health;


        }

        
        internal void PrintCharacter()
        {
            

            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(name);
            Console.ResetColor();

            Console.Write(" Class: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(classRPG);
            Console.ResetColor();

            Console.Write(" Armor: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(armor);
            Console.ResetColor();

            Console.Write(" Damage: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(damage);
            Console.ResetColor();

            Console.Write(" Health: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(health);
            Console.ResetColor();

            Console.WriteLine();

        }
        
    }
}
