using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtente
{
    public class Utente
    {
        public static string Username { get; private set; }
        private static string Password { get; set; }
        private static DateTime LastLogin
        {
            get; set;
        }
        private static List<DateTime> Accessi { get; } = new List<DateTime>();
        public static bool IsLogged => !string.IsNullOrEmpty(Username);

        public static void Login()
        {
            Console.Write("Inserisci username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Inserisci password: ");
            string inputPassword = Console.ReadLine();

            Console.Write("Conferma password: ");
            string confirmPassword = Console.ReadLine();

            if (inputUsername == "" || inputPassword != confirmPassword)
            {
                Console.WriteLine("Login fallito. Username vuota o password non coincidenti.");
            }
            else
            {
                Username = inputUsername;
                Password = inputPassword;
                LastLogin = DateTime.Now;
                Accessi.Add(LastLogin);
                Console.WriteLine("Login effettuato con successo.");
            }
        }
        public static void Logout()
        {
            if (IsLogged)
            {
                Username = null;
                Password = null;
                Console.WriteLine("Logout effettuato.");
            }
            else
            {
                Console.WriteLine("Nessun utente loggato.");
            }
        }

        public static void VerificaOraDataLogin()
        {
            if (IsLogged)
            {
                Console.WriteLine($"Ultimo login effettuato il: {LastLogin}");
            }
            else
            {
                Console.WriteLine("Nessun utente loggato.");
            }
        }

        public static void ListaAccessi()
        {
            if (IsLogged)
            {
                Console.WriteLine("Accessi precedenti:");
                foreach (DateTime accesso in Accessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Nessun utente loggato.");
            }
        }
        }
}
