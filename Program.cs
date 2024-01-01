using System.Reflection.Metadata;
using DiceRollGame;

var diceRollGame = new DiceRollGamee();
var randomGenerateNumber = new RandomGenerateNumber().RandomDiceNumber();
diceRollGame.CheckIfWinOrLose(randomGenerateNumber);

IList<User> patinets = new List<User>();

patinets.Where(x => x.Age > 20).Select(x => x.name).ToList();

if (patinents.Any(s => s.Name.Equals()))

Console.ReadLine();