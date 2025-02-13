using LoginWebApp;

        bool uscita = false;

        while (!uscita)
        {
            Console.Clear();
            Console.WriteLine("OPERAZIONI");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.WriteLine("3. Verifica ora e data di login");
            Console.WriteLine("4. Lista degli accessi");
            Console.WriteLine("5. Esci");
            Console.Write("Seleziona un'operazione: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Utente.Login();
                    break;
                case "2":
                    Utente.Logout();
                    break;
                case "3":
                    Utente.VerificaOraLogin();
                    break;
                case "4":
                    Utente.ListaAccessi();
                    break;
                case "5":
                    uscita = true;
                    break;
                default:
                    Console.WriteLine("Operazione non valida. Premi un tasto per continuare.");
                    Console.ReadKey();
                    break;
            }
        }
  
