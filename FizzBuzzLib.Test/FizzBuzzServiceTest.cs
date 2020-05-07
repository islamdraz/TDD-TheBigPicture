using TDD.Dll;
using Xunit;

namespace TddDll.Test
{
    public class FizzBuzzServiceTest
    {
        private readonly FizzBuzzService _fizzBuzzService;
        public FizzBuzzServiceTest()
        {
            _fizzBuzzService=new FizzBuzzService();
        }

        [Fact]
        public void ShouldReturnNumber()
        {
            
            Assert.Equal("1",_fizzBuzzService.Print(1));
            Assert.Equal("2",_fizzBuzzService.Print(2));
        }

        [Fact]
        public void ShouldReturnFizz()
        {
            Assert.Equal("Fizz",_fizzBuzzService.Print(3));
            Assert.Equal("Fizz",_fizzBuzzService.Print(9));
        }
        [Fact]
        public void ShouldReturnBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzzService.Print(5));
            Assert.Equal("Buzz", _fizzBuzzService.Print(10));
        }


        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _fizzBuzzService.Print(15));
            Assert.Equal("FizzBuzz", _fizzBuzzService.Print(30));
            
        }

    }
}
