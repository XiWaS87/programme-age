using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.Write("Entrez votre age : ");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("Ouf... Vous êtes majeur.");
            }
            else
            {
                Console.Write("Il faudra attendre un peu ...");
                Console.Write($"Vous serez majeur dans {18 - age} ans.");
            }
            Console.ReadLine();

        }
    }
}
