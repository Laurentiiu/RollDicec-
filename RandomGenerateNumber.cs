
namespace DiceRollGame
{
	public class RandomGenerateNumber
	{
		public int RandomDiceNumber()
		{
			var rnd = new Random();
			
			return rnd.Next(1, 7);
		}
	}
}

