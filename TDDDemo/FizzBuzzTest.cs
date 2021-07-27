using System;
using System.Collections.Generic;
using System.Text;
using Xunit; 

namespace TDDDemo
{
    public class FizzBuzzTest
    {
      [Fact]
      public void TestFizz()
        {
            //Assemble 
            FizzBuzz fb = new FizzBuzz();
            string expected = "fizz";

            //Act
            string actual = fb.GetFizzBuzz(5);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "buzz")]
        [InlineData(1, "")]
        [InlineData(15, "fizzbuzz")]
        public void TestFizzBuzz(int input, string expected)
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.GetFizzBuzz(input);

            Assert.Equal(expected, actual);
        }

    }
}
