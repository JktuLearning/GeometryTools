namespace GeometryTools
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(); 
            else 
                Radius = radius;
        }
    }
}
