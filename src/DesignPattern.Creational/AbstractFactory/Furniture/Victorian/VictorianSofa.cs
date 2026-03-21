namespace DesignPattern.Creational.AbstractFactory;

public class VictorianSofa : ISofa
{
    public void SitOn()
    {
        Console.WriteLine($"Sat on {GetType().Name}");
    }

    public bool HasLegs() => true;
    public bool HasCushion() => false;
}