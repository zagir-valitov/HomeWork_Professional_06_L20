using HomeWork_Professional_06_L20.Interfaces;

namespace HomeWork_Professional_06_L20.Implementation;

/// <summary>
/// Класс определяет способ генерации числа через генератор случайных чисел и реализует интерфейс INumberGenerator
/// </summary>
class RandomNumberGenerator : INumberGenerator
{    
    public int Number { get; set; }
    public void Generated(int minNumber, int maxNumber)
    {
        Random _randomNumber = new Random();
        Number =  _randomNumber.Next(minNumber, maxNumber);
    }
}
