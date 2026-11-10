
class Circle : Shape
{
    private double _ray;


    public Circle(string color, double ray) : base(color)
    {
        _ray = ray;
    }

    public override double GetArea()
    {
        return  _ray * _ray * Math.PI;
    }
}