namespace AbstractDemo;

public class Rectangle : Shape
{
    public int width { get; set; }
    public int height { get; set; }

    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public override double GetArea()
    {
        return width * height;
    }
}
