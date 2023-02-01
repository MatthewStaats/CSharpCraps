using System;

namespace PlayCraps
{
    class PlayCraps
    {
        int dice1;
        int dice2;
        int roll;
        int point;
        int rollcount = 0; 
        Random random = new Random();

        public PlayCraps()
        {
            dice1 = 0;
            dice2 = 0;
            roll = 0;
            point = 0;
            rollcount = 0;
        }

        public void Roll()
        {
            dice1 = random.Next(1, 6 + 1);
            dice2 = random.Next(1, 6 + 1);
            roll = dice1 + dice2;
        }

        public void Play()
        {
            Roll();
            rollcount++;
            point = roll;

            if (roll == 7 || roll == 11)
            {
                Console.WriteLine("Number of rolls: " + rollcount +"\n" +
                                  "Dice 1 roll: " + dice1 + "\n" +
                                  "Dice 2 roll: " + dice2 + "\n" +
                                  "Total Roll: " + roll + "\n" +
                                  "Congrats, you WON!" + "\n");
            } else if (roll == 2 || roll == 3 || roll ==12)
            {
                Console.WriteLine("Number of rolls: " + rollcount + "\n" +
                                  "Dice 1 roll: " + dice1 + "\n" +
                                  "Dice 2 roll: " + dice2 + "\n" +
                                  "Total Roll: " + roll + "\n" +
                                  "Sorry, you lose!" + "\n");
            } else
            {
                Console.WriteLine("\n" + "First Roll of the game was: " + roll + "\n" + "Pont to win is now: " + point);
                Console.WriteLine("Number of Rolls: " + rollcount + "\n");

                do
                {
                    Roll();
                    rollcount++;
                    Console.WriteLine("Current Dice Roll: " + roll + "\n" + 
                                      "Number of rolls: " + rollcount + "\n");

                    if (point == roll)
                    {
                        Console.WriteLine("It took " + rollcount + " rolls to hit point!" + 
                                          "\n" + "Congrats, you WON!" + "\n") ;
                        break;
                    }

                    if (roll == 7)
                    {
                        Console.WriteLine("It took " + rollcount + " rolls to hit unlucky 7" + "\n" +
                                          "Sorry, you lose!" +"\n");
                        break;
                    }

                } while (point != roll || roll != 7);
            }
        }

        // Reset game method
        public void Reset()
        {
            roll = 0;
            dice1 = 0;
            dice2 = 0;
            rollcount = 0;
            point = 0;
        }
        static void Main(string[] args)
        {
            PlayCraps play = new PlayCraps();
            play.Play();


            String answer;
            Console.WriteLine("Do you want to play again? Yes or No? ");
            answer = Console.ReadLine();
            if (answer == "no" || answer == "No" || answer == "NO" || answer == "n")
            {
                Environment.Exit(0);
            }

            do
            {
                play.Reset();
                play.Play();
                Console.WriteLine("Do you want to continue playing? Yes or No?");
                answer = Console.ReadLine();
                if (answer == "no" || answer == "No" || answer == "NO" || answer == "n")
                {
                    Environment.Exit(0);
                }
            } while (answer != "no" || answer != "No" || answer != "NO" || answer != "n");
            
        }
    }
}
