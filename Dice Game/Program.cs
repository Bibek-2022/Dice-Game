using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber;
            int enemyRandomNumber;

            int playerPoint = 0;
            int enemyPoint = 0;
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                playerRandomNumber = random.Next(1, 7);
                Console.WriteLine("You rolled " + playerRandomNumber);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1, 7);
                Console.WriteLine("Opposition rolled " + enemyRandomNumber);
           
                if(playerRandomNumber > enemyRandomNumber)
                {
                    playerPoint++;
                    Console.WriteLine("You win this round");
                }  else if (playerRandomNumber < enemyRandomNumber) {
                    enemyPoint++;
                    Console.WriteLine("Enemy win this round");
                } else
                {
                    Console.WriteLine("Its a Draw");
                }


                _ = (playerPoint > enemyPoint) ? "YOU WON THE MATCH" : "YOU LOOSE";

            }

            Console.ReadKey();
        }
    }
}
