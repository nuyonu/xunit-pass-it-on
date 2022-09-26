namespace Nasa.Helpers;

public class Calculator
{
    public Calculator()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    
    public int Sum(int numberOne, int numberTwo)
    {
        return numberOne + numberTwo;
    }
}
