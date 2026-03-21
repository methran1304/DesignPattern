namespace DesignPattern.Creational.AbstractFactory;

public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine($"Sat on {GetType().Name}");
    }

    public bool HasLegs()
    {
        return true;
    }

    public bool HasAdjustableSeatAngle()
    {
        return true;
    }
}