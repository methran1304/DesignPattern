namespace DesignPattern.Creational.Builder;

public interface IComputer
{
    string? CPU { get; set; }
    string? GPU { get; set; }
    int RAM { get; set; }
    void DisplaySpecification();
}