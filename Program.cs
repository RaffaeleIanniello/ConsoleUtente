using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utente.Login();
                        break;
                    case 2:
                        Utente.Logout();
                        break;
                    case 3:
                        Utente.VerificaOraDataLogin();
                        break;
                    case 4:
                        Utente.ListaAccessi();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
            }
    }
}
