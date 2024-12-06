namespace trade_simu
{
    public class Fonction
    {

        public static int EnterNumber(string question = "Enter a number...", string messageError = "It's not a number, try again !")
        {
            while (true)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine();
                //another method in private 
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine(messageError);
                }
            }
        }
    }
}
