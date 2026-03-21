namespace DesignPattern.Creational.Builder;

public class Desktop : IComputer
{
    public string? CPU { get; set; }
    public string? GPU { get; set; }
    public int RAM { get; set; }
    public string? Chassis { get; set; }

    public void DisplaySpecification()
    {
        Console.WriteLine($"Desktop\nCPU: {CPU}\nGPU: {GPU}\nRAM: {RAM}\nChassis: {Chassis}");
    }
}