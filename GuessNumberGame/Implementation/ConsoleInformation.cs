using HomeWork_Professional_06_L20.Interfaces;

namespace HomeWork_Professional_06_L20.Implementation;

/// <summary>
/// Класс определяет вывод информационных сообщение игрового процесса на консоль и реализует интерфейс IInformation
/// </summary>
class ConsoleInformation : IInformation
{
    public void Display(string information)
    {
        Console.Write(information);
    }
}
