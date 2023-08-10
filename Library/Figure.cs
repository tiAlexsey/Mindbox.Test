namespace Library;

public abstract class Figure
{
    public abstract string Name { get; }
    public abstract double GetArea();

    public void PrintInfo()
    {
        Console.WriteLine($"Figure - {Name} - have area = {GetArea()}");
    }
}