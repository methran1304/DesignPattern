namespace DesignPattern.Creational.FactoryMethod;

// Concrete creators override the factory method to change the
// resulting product's type.
// This return a WindowsButton which is of type IButton.
public class WindowsDialog : Dialog
{
    public override void Render()
    {
        Console.WriteLine($"{GetType().Name}: Render()");
    }

    public override IButton CreateButton()
    {
        return new WindowsButton();
    }
}