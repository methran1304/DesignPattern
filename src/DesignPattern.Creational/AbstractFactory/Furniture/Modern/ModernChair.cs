namespace DesignPattern.Creational.AbstractFactory;

public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine($"Sat on {GetType().Name}");
    }

    public bool HasLegs() => true;

    public bool HasAdjustableSeatAngle() => true;
}