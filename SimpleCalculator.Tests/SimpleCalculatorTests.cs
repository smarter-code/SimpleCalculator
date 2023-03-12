namespace SimpleCalculator.Tests
{
    public class SimpleCalculatorTests
    {
        private readonly SimpleCalculator _calculator;

        public SimpleCalculatorTests()
        {
            _calculator = new SimpleCalculator();
        }

        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            // Arrange
            int x = 4;
            int y = 6;
            int expected = 10;

            // Act
            int actual = _calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_ReturnsCorrectResult()
        {
            // Arrange
            int x = 10;
            int y = 4;
            int expected = 6;

            // Act
            int actual = _calculator.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero_ThrowsException()
        {
            // Arrange
            int x = 10;
            int y = 0;

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(x, y));
        }

        [Fact]
        public void Multiply_ReturnsCorrectResult()
        {
            // Arrange
            int x = 3;
            int y = 4;
            int expected = 12;

            // Act
            int actual = _calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}