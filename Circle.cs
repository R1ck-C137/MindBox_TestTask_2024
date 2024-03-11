namespace Shape
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius of the circle must not be less than or equal to zero");

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
