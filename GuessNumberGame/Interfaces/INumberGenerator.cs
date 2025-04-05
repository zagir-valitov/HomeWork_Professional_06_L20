namespace HomeWork_Professional_06_L20.Interfaces;

interface INumberGenerator
{
    public int Number { get; set; }
    public void Generated(int minNumber, int maxNumber);
}
