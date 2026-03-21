namespace DesignPattern;

using Creational.FactoryMethod;
using Creational.AbstractFactory;
using Creational.Builder;

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
        // Factory method (https://refactoring.guru/design-patterns/factory-method)
        // var factoryMethodClient = new Creational.FactoryMethod.FactoryMethodClient();
        // factoryMethodClient.Initialize();
        
        // Abstract Factory (https://refactoring.guru/design-patterns/abstract-factory)
        // var abstractFactoryClient = new AbstractFactoryClient();
        // abstractFactoryClient.Initialize();
        
        // Builder (https://refactoring.guru/design-patterns/builder)
        var builderClient = new BuilderClient();
        builderClient.Initialize();
    }
}