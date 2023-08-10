using NUnit.Framework;
using Library;

namespace UnitTest;

public class CircleTest
{
    [Test]
    public void CircleDontExists()
    {
        Assert.Throws<Exception>(() =>
        {
            Figure c = new Circle(0);
        });
    }

    [Test]
    public void CommonCircle()
    {
        Figure c = new Circle(5);
        c.PrintInfo();
        Assert.AreEqual(78.5398, c.GetArea(), 0.0001);
    }
}