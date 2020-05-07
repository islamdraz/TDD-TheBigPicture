using TDD.Dll;
using Xunit;

namespace TddDll.Test
{
    public class MyGenericStackTest
    {
        [Fact]
        public void ShouldReturnItem()
        {
            var stack = new MyGenericStack<string>();

            stack.Push("foo");
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void ShouldReturnMultipleItemsLastInFirstOut()
        {
            var stack = new MyGenericStack<string>();

            stack.Push("foo").Push("Hello");
        
            Assert.Equal("Hello", stack.Pop());
            Assert.Equal("foo", stack.Pop());
        }

        [Fact]
        public void ShouldReturnNull()
        {
            var stack=new MyGenericStack<string>();
            stack.Push(null);

            Assert.Equal(default,stack.Pop());
        }
    }
}
