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
            // Les identifiants sont:
            string login = "LaManu";
            string password = "bienvenue";
            // On demande à l'utilisateur de saisir son identifiant et mdp
            Console.WriteLine("Entrez votre identifiant : ");
            string userLogin = (Console.ReadLine());
            Console.WriteLine("Entrez votre mot de passe : ");
            string userPassword = (Console.ReadLine());
            // Si l'id et le mdp sont exacts alors on affiche un message de bienvenue
            if (userLogin == login && userPassword == password)
            {
                Console.WriteLine("Bienvenue à La Manu Le Havre !");
            }
            // Sinon on indique qu'il y a une erreur quelque part
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
        }
    }
}
