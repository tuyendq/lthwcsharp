namespace AbstractDemo;

public class Circle : Shape {
    public double radius { get; set; }
    
    public Circle(double r)
    {
        radius = r;
    }

    public override double GetArea() {
        return radius * radius * 3.14;
    }
}