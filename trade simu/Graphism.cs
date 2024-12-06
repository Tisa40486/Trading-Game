namespace trade_simu
{
    public class Graphism
    {
        public static void graphismMain()
        {

        }

        public static void waitinggraph(string foundOrNot)
        {

            for (int x = 0; x < 5; x++)
            {
                System.Threading.Thread.Sleep(400);
                Console.Write("-");
                
            }
            Console.Write(">");
            Console.Write(" ");
            Console.Write(foundOrNot);
            Console.WriteLine();

        }
    }
}
