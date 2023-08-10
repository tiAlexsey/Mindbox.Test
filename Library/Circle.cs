namespace Library;

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Validate(radius);

        Radius = radius;
    }

    public override string Name => nameof(Circle);
    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

    private void Validate(double radius)
    {
        if (radius <= 0)
        {
            throw new Exception("Radius must be positive");
        }
    }
}