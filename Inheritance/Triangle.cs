// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    //using constructor
    public Triangle()
    {

    }
    //using constructor
    public Triangle(int hyp)
    {

    }

    //using constructor
    public Triangle(int hyp, int height, int length)
    {
        Hypotenuese = hyp;
        Heigth = height;
        Length = length;
    }


    public double Hypotenuese { get; set; }
    public double Width { get; set; }

    public double GetArea()
    {
        return .5 * Length * Heigth;
    }

   
}
