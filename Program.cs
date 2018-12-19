using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition04
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "LaManu";
            string password = "bienvenue";

            Console.WriteLine("Entrez votre identifiant : ");
            string userLogin = (Console.ReadLine());
            Console.WriteLine("Entrez votre mot de passe : ");
            string userPassword = (Console.ReadLine());

            if (userLogin == login && userPassword == password) Console.WriteLine("Bienvenue à La Manu Le Havre !");
            else Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        }
    }
}
