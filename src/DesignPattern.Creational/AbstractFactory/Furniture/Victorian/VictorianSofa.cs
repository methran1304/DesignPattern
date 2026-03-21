namespace DesignPattern.Creational.AbstractFactory;

public class VictorianSofa : ISofa
{
    public void SitOn()
    {
        Console.WriteLine($"Sat on {GetType().Name}");
    }

    public bool HasLegs()
    {
        return true;
    }

    public bool HasCushion()
    {
        return false;
    }
}