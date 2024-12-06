namespace trade_simu
{
    public class minningClass
    {
        public static void minningMain()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---------Minning Coin--------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            int isExtract = getRandomPositionCoinExctracted();
            for (int i = 0; i < 100; i++)
            {
                int searchCoin = getRandomPositionForExtractCoin();
                setting(searchCoin, isExtract);
            }
        }



        public static void setting(int searchCoin, int isExtract)
        {
            int limitStock = 1000;
            int countCoin = 0;
            minning(isExtract, searchCoin, countCoin);
        }

        public static int getRandomPositionCoinExctracted()
        {
            Random random = new Random();
            int isExtract = 0;

            isExtract = random.Next(100);
            


            return isExtract;
        }
        public static int getRandomPositionForExtractCoin()
        {
            Random random = new Random();
            int searchCoin = 0;

            searchCoin = random.Next(100);


            return searchCoin;
        }
        public static void minning(int isExtract, int searchCoin, int countCoin)
        {



            if (isExtract == searchCoin)
            {
                 //---> for debug  Graphism.waitinggraph($"Coin found {searchCoin} - {isExtract}");
                Graphism.waitinggraph("Coin found ");
                countCoin++;
            }
            else
            {
                //---> for debug  Graphism.waitinggraph($"Coin Not found {searchCoin} - {isExtract}");
                Graphism.waitinggraph("Coin Not found");
            }

        }



    }
}

