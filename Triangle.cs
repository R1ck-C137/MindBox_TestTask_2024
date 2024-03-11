namespace Shape
{
    public class Triangle : IShape
    {
        private double _side1, _side2, _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("The side of the triangle must not be less than or equal to zero");
            if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
                throw new ArgumentException("One of the sides of the triangle is greater than the sum of the other two");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetArea()
        {
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }

        public bool IsRightAngled()
        {
            return Math.Pow(_side1, 2) + Math.Pow(_side2, 2) == Math.Pow(_side3, 2) ||
                   Math.Pow(_side1, 2) + Math.Pow(_side3, 2) == Math.Pow(_side2, 2) ||
                   Math.Pow(_side3, 2) + Math.Pow(_side2, 2) == Math.Pow(_side1, 2);
        }
    }
}
