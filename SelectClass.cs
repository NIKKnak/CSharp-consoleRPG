using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TreningRPG
{
    internal class SelectClass
    {
        internal void EnterClass()
        {
            List<string> NameClass = new List<string>();

            Console.WriteLine("Enter name");

            string name = Console.ReadLine();
            NameClass.Add(name);
            Console.Clear();

            Console.WriteLine("Select class\n1: Warior\t2: Assasin");
            

            string selectClass = Console.ReadLine();

            NameClass.Add(selectClass);


        }

    }
}
