using HomeWork_Professional_06_L20;
using HomeWork_Professional_06_L20.Implementation;

Console.WriteLine("Home Work 6. Guess The Number Game\n");

GuessNumberGame Game = new GuessNumberGame(
    new ConsoleInputSettings(), 
    new RandomNumberGenerator(), 
    new ConsolePlayProcess(), 
    new ConsoleInformation());
Game.ApplySettings();
Game.Start();
Game.Stop();