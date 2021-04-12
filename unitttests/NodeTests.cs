using System;
using System.Collections.Generic;
using System.Text;
using Tddstack;
using Xunit;

namespace unitttests
{
    public class NodeTests
    {

        [Fact]
        public void Node_Constructor_SetData()
        {
            // Arrange
            int expected = 5;

            // Act
            Node<int> node = new Node<int>(expected);
            int actual = node.Data;

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}