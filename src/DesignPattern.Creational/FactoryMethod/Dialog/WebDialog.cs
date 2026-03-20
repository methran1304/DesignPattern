using DesignPattern.DesignPattern.Creational.FactoryMethod.Button;

namespace DesignPattern.DesignPattern.Creational.FactoryMethod.Dialog;

// Concrete creators override the factory method to change the
// resulting product's type.
// This return a HtmlButton which is of type IButton.
public class WebDialog : Dialog
{
    public override void Render()
    {
        Console.WriteLine("WebDialog: Render()");
    }

    public override IButton CreateButton()
    {
        return new HtmlButton();
    }
}