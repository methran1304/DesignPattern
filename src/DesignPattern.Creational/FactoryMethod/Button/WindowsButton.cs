namespace DesignPattern.DesignPattern.Creational.FactoryMethod.Button;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("WindowsButton: Render()");
    }

    public void OnClick()
    {
        Console.WriteLine("WindowsButton: OnClick()");
    }
}