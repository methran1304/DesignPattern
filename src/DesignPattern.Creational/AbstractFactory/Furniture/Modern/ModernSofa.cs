namespace DesignPattern.Creational.AbstractFactory;

public class ModernSofa : ISofa
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
        return true;
    }
}