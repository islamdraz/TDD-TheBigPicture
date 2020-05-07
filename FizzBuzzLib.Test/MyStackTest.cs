using System;
using TDD.Dll;
using Xunit;

namespace TddDll.Test
{
    
  public class MyStackTest
    {

        [Fact]
        public void ShouldReturnValue()
        {
            var stack = new MyStack(100);

            stack.Push("Foo");
            Assert.Equal("Foo",stack.Pop());
        }

        [Fact]
        public void ShouldReturnLastINFirstOut()
        {
            var stack = new MyStack(100);

            stack.Push("Foo");
            stack.Push("Hello");
            Assert.Equal("Hello", stack.Pop());
            Assert.Equal("Foo", stack.Pop());
        }

        [Fact]
        public void ShouldThrowExceptionWhenNoItem()
        {
            var stack = new MyStack(100);


            Assert.Throws<Exception>(() => { stack.Pop(); });
        }

    }
}
