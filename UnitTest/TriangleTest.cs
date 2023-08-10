using NUnit.Framework;
using Library;

namespace UnitTest;

public class TriangleTest
{
    [Test]
    public void TriangleSideIsNotPositive()
    {
        Assert.Throws<Exception>(() =>
        {
            Figure tr = new Triangle(0, 0, 0);
        });
    }

    [Test]
    public void TriangleDontExist()
    {
        Assert.Throws<Exception>(() =>
        {
            Figure tr = new Triangle(1, 3, 4);
        });
    }

    [Test]
    public void PythagorasTriangle()
    {
        Figure tr = new Triangle(5, 3, 4);
        tr.PrintInfo();
        Assert.AreEqual(6, tr.GetArea(), 0.0001);
    }

    [Test]
    public void CommonTriangle()
    {
        Figure tr = new Triangle(7, 5, 9);
        tr.PrintInfo();
        Assert.AreEqual(17.4123, tr.GetArea(), 0.0001);
    }
}