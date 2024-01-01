using System;


namespace DiceRollGame
{
	public class DiceRollGamee
	{
		private int Tries { get; set; } = 1;
		
		public void CheckIfWinOrLose(int randomNumber)
		{
            Console.WriteLine($"Dice rolled. Guess what number it shows in 3 tries.");
            bool inputValid = false;
            while (!inputValid)
            {
                Console.WriteLine("Enter a number: ");
                var userInput = Console.ReadLine();
                var intInput = int.TryParse(userInput, out int Number);
                
                if (intInput && Number >= 1 && Number <= 6)
                {
                    if (Tries <= 3 && randomNumber == Number)
                    {
                        Console.WriteLine("You win! :))");
                        break;
                    }
                    else if (Tries < 3 && randomNumber != Number)
                    {
                        ++Tries;
                        Console.WriteLine("Wrong number!");
                        
                    }
                    else if(Tries == 3 && randomNumber != Number)
                    {
                        Console.WriteLine("You lose :(");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
	}
}

