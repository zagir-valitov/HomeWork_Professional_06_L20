using HomeWork_Professional_06_L20.Interfaces;

namespace HomeWork_Professional_06_L20.Implementation;

/// <summary>
/// Класс определяет взамодействие с игоровым процессом через консоль и реализует интерфейс IPlayProcess
/// </summary>
class ConsolePlayProcess : IPlayProcess
{
    public int Play()
    {        
        int number;
        while (true)
        {
            Console.Write("Input number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                break;
            }
            else 
            {
                Console.WriteLine("Incorrect number!!!\n");
            }
        }      
        return number;        
    }
}
