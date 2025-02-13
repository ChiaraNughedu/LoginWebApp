namespace LoginWebApp
{
    public static class Utente
    {
        public static string Username { get; private set; } = null;
        public static DateTime? LoginTime { get; private set; } = null;
        public static List<DateTime> AccessList { get; private set; } = new List<DateTime>();

        public static void Login()
        {
            if (Username != null)
            {
                Console.WriteLine("Errore: Sei già loggato come " + Username);
                Console.ReadKey();
                return;
            }

            Console.Write("Inserisci username: ");
            string username = Console.ReadLine();

            Console.Write("Inserisci password: ");
            string password = Console.ReadLine();

            Console.Write("Conferma password: ");
            string confermaPassword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Errore: Il nome utente non può essere vuoto.");
            }
            else if (password != confermaPassword)
            {
                Console.WriteLine("Errore: Le password non coincidono.");
            }
            else
            {
                Username = username;
                LoginTime = DateTime.Now;
                AccessList.Add(LoginTime.Value);
                Console.WriteLine("Login effettuato con successo.");
            }

            Console.ReadKey();
        }

        public static void Logout()
        {
            if (Username == null)
            {
                Console.WriteLine("Errore: Nessun utente è loggato.");
            }
            else
            {
                Console.WriteLine($"Logout effettuato per l'utente {Username}.");
                Username = null;
                LoginTime = null;
            }

            Console.ReadKey();
        }

        public static void VerificaOraLogin()
        {
            if (Username == null || LoginTime == null)
            {
                Console.WriteLine("Errore: Nessun utente è loggato.");
            }
            else
            {
                Console.WriteLine($"Utente {Username} loggato alle: {LoginTime}");
            }

            Console.ReadKey();
        }

        public static void ListaAccessi()
        {
            if (AccessList.Count == 0)
            {
                Console.WriteLine("Nessun accesso registrato.");
            }
            else
            {
                Console.WriteLine("Lista degli accessi:");
                foreach (DateTime accesso in AccessList)
                {
                    Console.WriteLine(accesso);
                }
            }

            Console.ReadKey();
        }
    }
}
