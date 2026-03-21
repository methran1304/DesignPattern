namespace DesignPattern.Creational.Builder;

public class Laptop : IComputer
{
    public string? CPU { get; set; }
    public string? GPU { get; set; }
    public int RAM { get; set; }
    public int BatteryCapacity { get; set; }
    public bool HasFullRotationHinge { get; set; }

    public void DisplaySpecification()
    {
        Console.WriteLine($"Laptop\nCPU: {CPU}\nGPU: {GPU}\nRAM: {RAM}\nBattery: {BatteryCapacity}h\nFull Rotation Hinge: {HasFullRotationHinge}");
    }
}