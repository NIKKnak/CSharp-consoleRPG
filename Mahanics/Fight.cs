﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningRPG.Classes;
using TreningRPG.Mahanics;

namespace TreningRPG
{
    internal class Fight
    {

        internal void StartBattle(MainClass hero, MainClass enemy)
        {
            DamageHero damageHero = new DamageHero();
            Console.WriteLine($"Hero Health: {hero.health}, Enemy Health: {enemy.health}");
            while (hero.health > 0 && enemy.health > 0)
            {

                Console.WriteLine("\n\nSelect an action");
                Console.WriteLine($"1: Attack \t 2:Defend");

                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {

                    enemy.health = damageHero.Damage(hero.damage, enemy.armor, enemy.health);
                    Console.WriteLine($"{hero.name} нанес урон {enemy.name}.");

                }
                else if (select == 2)
                {
                    hero.armor += 30;
                }


                if (enemy.health <= 0) break;

                hero.health = damageHero.Damage(enemy.damage, hero.armor, hero.health);
                Console.WriteLine($"{enemy.name} нанес урон {hero.name}.");

                if (select == 2)
                {
                    hero.armor -= 30;
                }



                hero.PrintCharacter();
                enemy.PrintCharacter();

            }

            if (hero.health > 0)
            {
                Console.WriteLine("Победа!");
            }
            else
            {
                Console.WriteLine("Вы пали в бою...");
            }


        }
    }
}
