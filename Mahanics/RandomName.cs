using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TreningRPG
{
    internal class RandomName
    {
        public static List<string> rndName = new List<string>() { "Skeleton Nik", "Skeleton Jack", "Skeleton Rik", "Skeleton Morty", "Skeleton Frank", "Skeleton Lui", "Skeleton Bob" };
        public static string GetName()
        {

            Random rnd = new Random();
            int index = rnd.Next(rndName.Count);
            return rndName[index];
        }
    }
}





