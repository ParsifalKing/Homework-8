
class Circle
{
    
    double radius;
    double PI = 3.14159;
    // constructor
    public Circle(double _radius)
    {
        radius = _radius;
    }
    public Circle()
    {
        radius = 0.0;
    }
    // method
    public void SetRadius(double _enterRadius)
    {
        radius = _enterRadius;
    }
     public double GetRadius()
    {
        return radius;
    }
    public double GetArea()
    {
        double area;
        area= PI * radius * radius;
        return area;
    }
    public double GetDiametr()
    {
        double diametr;
        diametr = radius * 2;
        return diametr;
    }

    public double GetCircumference()
    {
        double circumference;
        circumference = radius * 2 * PI;
        return circumference;
    }

}