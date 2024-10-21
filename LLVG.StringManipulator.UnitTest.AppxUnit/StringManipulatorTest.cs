using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLVG.StringManipulator.UnitTest.AppxUnit
{
    public class StringManipulatorTest
    {
        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_ShouldHandleEmptyString()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "";
            string expected = "";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.ReverseString(null));
        }
        [Fact]
        public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
        {
            StringManipulator manipulator = new StringManipulator();
            string input = "hello world";
            string expected = "helloworld";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldHandleStringWithNoSpaces()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "helloworld";
            string expected = "helloworld";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void RemoveSpaces_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.RemoveSpaces(null));
        }

    }
}
