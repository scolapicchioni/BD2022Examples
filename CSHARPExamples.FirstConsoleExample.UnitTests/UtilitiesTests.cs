namespace CSHARPExamples.FirstConsoleExample.UnitTests {
    public class UtilitiesTests {
        [Fact]
        public void Greatest_ShouldReturnTheFirstParameter_WhenTheFirstParameterIsHigherThanTheSecond() {
            //Create a method called Greatest().
            //This method has 2 parameters with type int and returns the highest parameter.

            //Arrange
            int firstParameter = 10;
            int secondParameter = 1;
            int expected = 10;

            //Act
            int actual = Utilities.Greatest(firstParameter, secondParameter);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Greatest_ShouldReturnTheSecondParameter_WhenTheFirstParameterIsLowerThanTheSecond() {
            //Create a method called Greatest().
            //This method has 2 parameters with type int and returns the highest parameter.

            //Arrange
            int firstParameter = 1;
            int secondParameter = 10;
            int expected = 10;

            //Act
            int actual = Utilities.Greatest(firstParameter, secondParameter);

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Greatest_ShouldReturnTheFirstParameter_WhenTheFirstParameterIsEqualToTheSecond() {
            //Create a method called Greatest().
            //This method has 2 parameters with type int and returns the highest parameter.

            //Arrange
            int firstParameter = 1;
            int secondParameter = 1;
            int expected = 1;

            //Act
            int actual = Utilities.Greatest(firstParameter, secondParameter);

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Swap_ShouldSwapTheValueOfTheArguments() {
            //Arrange
            int firstArgument = 5;
            int secondArgument = 10;

            //Act
            Utilities.Swap(ref firstArgument, ref secondArgument);

            //Assert
            Assert.Equal(10, firstArgument);
            Assert.Equal(5, secondArgument);
        }

    }
}