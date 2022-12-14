using System.Text;
using FluentAssertions;

namespace CSHARPExamples.FirstConsoleExample.UnitTests; 
public class ArraysTests {
    [Fact]
    public void GenerateUniqueMatrix_ShouldGenerateAMatrixOfGivenSize() {
        //Arrange
        int height = 5;
        int width = 3;
        ArraysExamples example = new ArraysExamples();

        //Act
        int[,] actual = example.GenerateUniqueMatrix(height, width);

        //Assert
        Assert.Equal(height, actual.GetLength(0));
        Assert.Equal(width, actual.GetLength(1));
    }
    [Fact]
    public void GenerateUniqueMatrix_ShouldGenerateAUniqueMatrix() {
        //Arrange
        int height = 5;
        int width = 3;
        ArraysExamples example = new ArraysExamples();

        //Act
        int[,] actual = example.GenerateUniqueMatrix(height, width);

        int[] flattened = actual.Cast<int>().ToArray();
        //Assert
        flattened.Should().OnlyHaveUniqueItems();
    }
    [Fact]
    public void Lab01_ShouldAskNumbersToTheUsersAndPrintTheSumOfAllNumbers() {
        //Arrange
        StringBuilder userInput = new StringBuilder();
        userInput.AppendLine("3");
        userInput.AppendLine("5");
        userInput.AppendLine("7");
        userInput.AppendLine("9");
        userInput.AppendLine("1");
        userInput.AppendLine("2");
        userInput.AppendLine("4");
        userInput.AppendLine("6");
        userInput.AppendLine("8");
        userInput.AppendLine("0");
        TextReader newIn = new StringReader(userInput.ToString());

        StringBuilder outputString = new StringBuilder();
        TextWriter newOut = new StringWriter(outputString);

        Console.SetIn(newIn);
        Console.SetOut(newOut);

        string expected = "Please insert number 1: Please insert number 2: Please insert number 3: Please insert number 4: Please insert number 5: Please insert number 6: Please insert number 7: Please insert number 8: Please insert number 9: Please insert number 10: The sum of 3  + 5  + 7  + 9  + 1  + 2  + 4  + 6  + 8  + 0  is 45\r\n";

        ArraysExamples arraysExamples = new ArraysExamples();

        //Act
        arraysExamples.Lab01();

        //Assert
        Assert.Equal(expected, outputString.ToString());

    }
}
