
class Rectangle : Shape
{
    private double _baseSide;
    private double _height;

    public Rectangle(string color, double baseSide, double height) : base(color)
    {
        _baseSide = baseSide;
        _height = height;

    }

    public override double GetArea()
    {
        return  _baseSide * _height;
    }
}