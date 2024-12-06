using System.Text.Json;

namespace trade_simu
{
    class Connexion_class
    {
        public static void connexionMain()
        {
            bool connexionCheck = false;
            string identifiant = "XXX";
            string password = "XXX";


            Console.WriteLine("Hi, Welcome to your economie strategie and trading simulation");
            Console.WriteLine("");
            Console.WriteLine("before start we need to know who are you, please interact.");
            Console.WriteLine("");


            identifiant = createAnAccount("Enter your identifiant");
            password = createAnAccount("Enter your password");
            
            Console.WriteLine("Thanks, your account will be enregistred with any problem");
            Console.WriteLine("");
            
            while (connexionCheck != true)
            {
                connexionCheck = connexion(identifiant, password);

            }
                 
        }
        public static string createAnAccount(string message) 
        {
            string informations = getReponse(message);
            
            return informations;
        }
        public static string getReponse(string message)
        {
            string informationConnexion = "XX";
            Console.WriteLine(message);
            informationConnexion = Console.ReadLine();
            return informationConnexion;
        }
        private static bool connexion(string signIn, string password)
        {
            int attemptConnexionMax = 3;
            int numberOfAttemptsConnexion = 1;

            bool isValid = false;

            Console.WriteLine($"Attempts of connexion. You have {attemptConnexionMax} try in maximum");

            while (!isValid)
            {
                Console.WriteLine($"try {numberOfAttemptsConnexion} on {attemptConnexionMax}");
                isValid = attemptConnexion(signIn, password);
                numberOfAttemptsConnexion = DisplayStatesTryOfConnexion(isValid, numberOfAttemptsConnexion);
                if (numberOfAttemptsConnexion == attemptConnexionMax)
                {
                    Console.WriteLine("access restricted");
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("access valid");
            }
            return true;



        }
        private static bool attemptConnexion(string identifiant, string password)
        {
            string verifIdentifiant = "XXX";
            string verifPassword = "XXX";

            Console.WriteLine("Enter your identifiant");
            verifIdentifiant = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Enter your password");
            verifPassword = Console.ReadLine();

            if (verifIdentifiant == identifiant && verifPassword == password)
            {

                return true;
            }

            return false;
        }

        private static int DisplayStatesTryOfConnexion(bool estAuthentifie, int tentative)
        {
            if (estAuthentifie)
            {
                Console.WriteLine($"Connexion réussie!");
                return tentative;
            }
            else
            {
                tentative++;
            }
            return tentative;
        }
    }


}

