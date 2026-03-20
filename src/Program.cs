using DesignPattern.DesignPattern.Creational.FactoryMethod;

namespace DesignPattern;

/*
    A collection of software design patterns implemented in C#.
    The 'DesignPattern' solution organizes patterns by category: Creational, Behavioral and Structural
    with each group placed in its own class library project.
    Author: Methran
*/

public static class Program
{
    public static void Main()
    {
        // Factory method
        var client = new FactoryMethodClient();
        client.Initialize();
    }
}