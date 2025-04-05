using HomeWork_Professional_06_L20.Interfaces;

namespace HomeWork_Professional_06_L20;
/// <summary>
/// Класс верхнего уровня определяет логику игры и реализует интерфейс IGame
/// </summary>
class GuessNumberGame : IGame
{
    public Dictionary<string, int> Settings { get; private set; } = new Dictionary<string, int>()
    {
        ["Attempts"] = 3,
        ["MinNumber"] = 0,
        ["MaxNumber"] = 10
    };
    public int Score = 0;
    public ISettingsReader<Dictionary<string, int>> SettingsReader;
    public INumberGenerator NumberGenerated;
    public IPlayProcess PlayProcess;
    public IInformation Information;
    
    public GuessNumberGame(
        ISettingsReader<Dictionary<string, int>> settingsReader, 
        INumberGenerator generatedNumber, 
        IPlayProcess playProcess, 
        IInformation information)
    {
        SettingsReader = settingsReader;
        NumberGenerated = generatedNumber;
        PlayProcess = playProcess;
        Information = information;
    }

    public void Start()
    {
        NumberGenerated?.Generated(Settings["MinNumber"], Settings["MaxNumber"]);
        Information.Display(
            $"Guess the number from {Settings["MinNumber"]} to {Settings["MaxNumber"]}\n" +
            $"[ Hidden number - {NumberGenerated?.Number} ]");

        int userNumber;
        for (int i = Settings["Attempts"]; i > 0;)
        {
            Information.Display($"\nAttempts Left - {i}\n");
            userNumber = PlayProcess.Play();
            if (userNumber == NumberGenerated?.Number)
            {
                Score++;
                i = Settings["Attempts"];
                NumberGenerated?.Generated(Settings["MinNumber"], Settings["MaxNumber"]);

                Information.Display("You guessed the number!!!\n");                
                Information.Display($"\n[ Hidden number - {NumberGenerated?.Number} ]");
            }
            else if (userNumber > NumberGenerated?.Number)
            {
                Information.Display("Your number is higher!\n");
                i--;
            }
            else if (userNumber < NumberGenerated?.Number)
            {
                Information.Display("Your number is less!\n");
                i--;
            }
        }        
    }

    public void Stop()
    {
        Information.Display($"\nThe game is over with a score {Score}\n");
    }

    public void ApplySettings()
    {
        SettingsReader.Set();
        Settings = SettingsReader.Get();
        Score = 0;
    }
}

    
