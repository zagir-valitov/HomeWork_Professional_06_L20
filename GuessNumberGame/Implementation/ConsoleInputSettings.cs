using HomeWork_Professional_06_L20.Interfaces;

namespace HomeWork_Professional_06_L20.Implementation;

/// <summary>
/// Класс определяет настройку игры через консоль и реализует интерфейс ISettingsReader
/// </summary>
class ConsoleInputSettings : ISettingsReader<Dictionary<string, int>>
{
    public Dictionary<string, int> Settings { get; private set; } = new Dictionary<string, int>()
    {
        ["Attempts"] = 1,
        ["MinNumber"] = 0,
        ["MaxNumber"] = 10
    };

    public Dictionary<string, int> Get()
    {
        return Settings;
    }

    public void Set()
    {
        Console.WriteLine("" +
            "Input Settings\n" +
            "------------------------");
        foreach(var key in Settings.Keys)
        {
            Console.Write($"{key} = ");
            if (int.TryParse(Console.ReadLine(), out int setting))
            {
                Settings[key] = setting;
            }
        } 
        Console.WriteLine("------------------------\n");
    }
}
