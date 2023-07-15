using Microsoft.VisualStudio.TestPlatform.TestHost;
using Lab3;
namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void Test_ProductOfAllNumbers()
        {
            // Arrange
            string input = "4 8 15";

            // Act
            decimal result = Lab3.Program.MultiplyNumbers(input);

            // Assert
            Assert.Equal(480, result);
        }

        [Fact]
        public void Test_MoreThanThreeNumbers()
        {
            // Arrange
            string input = "4 8 15 16 23";

            // Act
            decimal result = Lab3.Program.MultiplyNumbers(input);

            // Assert
            Assert.Equal(480, result);
        }

        [Fact]
        public void Test_LessThanThreeNumbers()
        {
            // Arrange
            string input = "4 8";

            // Act
            decimal result = Lab3.Program.MultiplyNumbers(input);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_HandleNegativeNumbers()
        {
            // Arrange
            string input = "-4 -8 -15";

            // Act
            decimal result = Lab3.Program.MultiplyNumbers(input);

            // Assert
            Assert.Equal(-480, result);
        }






        [Fact]
        public void Challenge9_ValidInput_ReturnsWordCharacterCounts()
        {
            // Arrange
            string sentence = "This is a sentence about important things";
            string[] expectedOutput = { "This: 4", "is: 2", "a: 1", "sentence: 8", "about: 5", "important: 9", "things: 6" };

            // Act
            string[] wordArray = Lab3.Program.GetWordCharacterCounts(sentence);

            // Assert
            Assert.Equal(expectedOutput, wordArray);
        }

        [Fact]
        public void Challenge9_EmptyInput_ReturnsEmptyArray()
        {
            // Arrange
            string sentence = "";
            string[] expectedOutput = { };

            // Act
            string[] wordArray = Lab3.Program.GetWordCharacterCounts(sentence);

            // Assert
            Assert.Equal(expectedOutput, wordArray);
        }

        [Fact]
        public void Challenge9_InputWithSymbols_ReturnsWordCharacterCounts()
        {
            // Arrange
            string sentence = "Hello, world! This is a sentence.";
            string[] expectedOutput = { "Hello: 5", "world: 5", "This: 4", "is: 2", "a: 1", "sentence: 8" };

            // Act
            string[] wordArray = Lab3.Program.GetWordCharacterCounts(sentence);

            // Assert
            Assert.Equal(expectedOutput, wordArray);
        }


    }
}