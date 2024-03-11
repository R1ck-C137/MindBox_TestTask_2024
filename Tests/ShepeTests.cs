using Shape;

namespace Tests
{
    public class ShepeTests
    {
        [Fact]
        public void CircleAreaCalculation()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.Equal(78.53981633974483, area);
        }

        [Fact]
        public void CircleWithZeroRadiusException()
        {
            // Arrange
            double radius = 0;

            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void TriangleAreaCalculation()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void TriangleWithZeroSideException()
        {
            // Arrange
            double side1 = 0;
            double side2 = 4;
            double side3 = 5;

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void TriangleWithTooLongSideException()
        {
            // Arrange
            double side1 = 20;
            double side2 = 4;
            double side3 = 5;

            // Assert
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void CompileTimeAreaCalculation()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            IShape shape = new Triangle(side1, side2, side3);

            // Act
            double area = shape.GetArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void RightAngledTriangleCheck()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }
    }
}