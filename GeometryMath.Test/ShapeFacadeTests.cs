using System;
using GeometryMath.Figures;

namespace GeometryMath.Test
{
    public class ShapeFacadeTests
    {
        private ShapeFacade _shapeFacade;

        public ShapeFacadeTests()
        {
            _shapeFacade = new ShapeFacade();
        }

        [Fact]
        public void CircleAreaByRadius_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;

            // Act
            double result = _shapeFacade.CircleAreaByRadius(radius);

            // Assert
            Assert.Equal(expectedArea, result, 4);
        }

        [Fact]
        public void TriangleAreaBySides_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double a = 3, b = 4, c = 5;
            double expectedArea = 6; // Используем треугольник 3-4-5

            // Act
            double result = _shapeFacade.TriangleAreaBySides(a, b, c);

            // Assert
            Assert.Equal(expectedArea, result, 4);
        }

        [Fact]
        public void TriangleIsEquilateral_EquilateralSides_ReturnsTrue()
        {
            // Arrange
            double a = 2, b = 2, c = 2;

            // Act
            bool result = _shapeFacade.TriangleIsEquilateral(a, b, c);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TriangleIsEquilateral_NonEquilateralSides_ReturnsFalse()
        {
            // Arrange
            double a = 2, b = 2, c = 3;

            // Act
            bool result = _shapeFacade.TriangleIsEquilateral(a, b, c);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void CalculateTotalArea_WithMultipleShapes_ReturnsCorrectTotalArea()
        {
            // Arrange
            var circle = new Circle(5); // Площадь = 78.5398
            var triangle = new Triangle(3, 4, 5); // Площадь = 6
            double expectedTotalArea = circle.Area + triangle.Area;

            // Act
            double result = _shapeFacade.CalculateTotalArea(circle, triangle);

            // Assert
            Assert.Equal(expectedTotalArea, result, 4);
        }
    }
}
