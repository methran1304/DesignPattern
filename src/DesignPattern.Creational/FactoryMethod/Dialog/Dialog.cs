using DesignPattern.DesignPattern.Creational.FactoryMethod.Button;

namespace DesignPattern.DesignPattern.Creational.FactoryMethod.Dialog;

/*
 * The base Dialog class uses different UI elements to render its window.
 * Under various operating systems, these elements may look a little bit different, but they should still behave consistently.
 * A button in Windows is still a button in Linux.
 */

// The creator class declares the factory method that must
// return an object of a product class. The creator's subclasses
// usually provide the implementation of this method.
public abstract class Dialog
{
    public abstract void Render();

    public abstract IButton CreateButton(); // factory method
}