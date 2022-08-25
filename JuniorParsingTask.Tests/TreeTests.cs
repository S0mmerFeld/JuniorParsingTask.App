using System;
using Xunit;
using JuniorParsingTask;

namespace JuniorParsingTask.Tests
{
    public class TreeTests
    {
        [Theory]
        [InlineData("eree", false)]
        [InlineData("dsfd", false)]
        [InlineData("", false)]
        public void Should_ReturnFalse_When_NodeNotInTree(string searchstr, bool expectedTestResult)
        {
            //Arrange
            var tree = TreeService.Create();

            //Act
            Node testNode;
            bool isValid = tree.TryGetNode(searchstr, out testNode);

            //Assert
            Assert.Equal(expectedTestResult, isValid);
        }

        [Theory]
        [InlineData("learning", true)]
        [InlineData("xyz", true)]
        public void Should_ReturnTrue_When_NodeInTree(string searchstr, bool expectedTestResult)
        {
            //Arrange
            var tree = TreeService.Create();

            //Act
            Node testNode;
            bool isValid = tree.TryGetNode(searchstr, out testNode);

            //Assert
            Assert.Equal(expectedTestResult, isValid);
        }


        [Fact]
        public void Should_ReturnNull_When_NodeInTree()
        {
            //Arrange
            var tree = TreeService.Create();

            //Act
            Node testNode;
            bool isValid = tree.TryGetNode("null", out testNode);

            //Assert
            Assert.Null(testNode);
        }

        [Fact]
        public void Should_ReturnNode_When_NodeNotInTree()
        {
            //Arrange
            var tree = TreeService.Create();

            //Act
            Node testNode;
            bool isValid = tree.TryGetNode("xyz", out testNode);

            //Assert
            Assert.NotNull(testNode);

        }
       
    }
}
