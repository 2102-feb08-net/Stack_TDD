using System;
using Xunit;
using Tddstack;

namespace unitttests
{
    public class UnitTest1
    {
        [Fact]
        public void Stack_IsEmpty_Returnstrue()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            // Act
            bool actual = stack.IsEmpty();

            // Assert
            Assert.True(actual);

        }

        [Fact]
        public void Stack_PushNode_NotEmpty()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            Node<object> node = new Node<object>(data);

            //Act
            stack.Push(node);

            bool isEmpty = stack.IsEmpty();

            //Assert
            Assert.False(isEmpty);

        }

        [Fact]
        public void Stack_PushMultipleNodesThenPop_NotEmpty()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            //Act
            stack.Push(data);
            stack.Push(data);
            stack.Pop();

            bool isEmpty = stack.IsEmpty();

            //Assert
            Assert.False(isEmpty);

        }



        [Fact]
        public void Stack_PushNode_CountIncrease()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            int expected = 1;

            //Act
            stack.Push(data);

            int actual = stack.Count;

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Stack_PopNode_CountDecrease()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            Node<object> node = new Node<object>(data);

            int expected = 0;

            stack.Push(node);

            //Act
            stack.Pop();

            int actual = stack.Count;

            //Assert
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Stack_PopNode_ReturnsLastNode()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            stack.Push(data);

            //Act
            var poppedData = stack.Pop();

            //Assert
            Assert.Equal(data, poppedData);

        }

        [Fact]
        public void Stack_PopEmptyNode_ThrowInvalidOperation()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            //Act
            object poppedData() => stack.Pop();

            //Assert
            Assert.ThrowsAny<InvalidOperationException>(poppedData);

        }


        [Fact]
        public void Stack_PopNode_RemovesTopNode()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            int data2 = 20;

            stack.Push(data);

            object expectedData = stack.Peek();

            stack.Push(data2);

            //Act
            stack.Pop();

            var topNode = stack.Peek();

            //Assert
            Assert.Equal(expectedData, topNode);

        }


        [Fact]
        public void Stack_PeekNode_ReturnsLastNode()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            int data = 10;

            stack.Push(data);

            //Act
            var peekedNode = stack.Peek();

            //Assert
            Assert.Equal(data, peekedNode);

        }

        [Fact]
        public void Stack_PeekEmpty_ReturnsInvalidOperation()
        {
            // Arrange
            Stack<object> stack = new Stack<object>();

            //Act
            object peekedNode () => stack.Peek();

            //Assert
            Assert.ThrowsAny<InvalidOperationException>(peekedNode);

        }


    }
}
