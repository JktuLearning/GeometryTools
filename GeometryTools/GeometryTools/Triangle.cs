namespace GeometryTools
{
    public class Triangle : GeometricFigure
    {
        public double Hypotenuse { get; private set; }
        public double[] Legs { get; private set; }
        public double Perimeter { get; private set; }
        public bool IsRectangular { get; private set; }

        public double GetArea() => Math.Sqrt(Perimeter * (Perimeter - Legs[0])
                                                       * (Perimeter - Legs[1])
                                                       * (Perimeter - Hypotenuse));

        public Triangle(params double[] sides)
        {
            for (int i = 0; i < sides.Length; i++)
                if (sides[i] < 0) throw new ArgumentOutOfRangeException();

            Perimeter = sides.Sum();

            Hypotenuse = sides.Max();
            Legs = sides.Except(new[] { Hypotenuse }).ToArray();

            IsRectangular = (Math.Pow(Hypotenuse, 2) == Math.Pow(Legs[0], 2) + Math.Pow(Legs[1], 2));
        }
    }
}
