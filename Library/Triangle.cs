namespace Library;

public class Triangle : Figure
{
    private readonly bool _pythagoras;

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double a, double b, double c)
    {
        Sort(ref a, ref b, ref c);
        Validate(a, b, c);

        SideA = a;
        SideB = b;
        SideC = c;

        _pythagoras = IsPythagorasTriangle();
    }

    public override string Name => nameof(Triangle);

    public override double GetArea()
    {
        if (_pythagoras)
        {
            return SideA * SideB / 2;
        }

        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    private bool IsPythagorasTriangle()
    {
        var epsilon = 0.0001;
        return (Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) < epsilon);
    }

    private void Sort(ref double a, ref double b, ref double c)
    {
        if (a > b)
        {
            (a, b) = (b, a);
        }

        if (b > c)
        {
            (b, c) = (c, b);
        }
    }

    private void Validate(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new Exception("Sides must be positive");
        }

        if (a + b <= c)
        {
            throw new Exception("Triangle don't exist");
        }
    }
}