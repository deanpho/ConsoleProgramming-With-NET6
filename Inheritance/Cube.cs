// See https://aka.ms/new-console-template for more information
class Cube : Shape, IShape
{
    public Cube(int width, int heigth, int length)
    {
        Width = width;
        Heigth = heigth;
        Length = length;
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double GetVolumn()
    {
        return Length * Width * Heigth;
    }
}

