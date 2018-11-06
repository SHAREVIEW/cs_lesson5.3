using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = new string[3] { "Robert Barwell", "Mike Parry", "Jeremy Beacock"};
            // string[] friendNames = { "Robert Barwell", "Mike Parry", "Jeremy Beacock"}; array definition
            int i;
            Console.WriteLine("Here are {0} of my friends.", friendNames.Length);
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(  friendNames[i]);
            }
            Console.ReadKey();

        }
    }
}
