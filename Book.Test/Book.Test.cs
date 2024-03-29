using Book.Core;
using System;
using Xunit;

namespace Book.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var BookCopy = new BookClass("");
            BookCopy.AddGrade(50.5);
            BookCopy.AddGrade(75);
            BookCopy.AddGrade(100);

            //Act
            var Result = BookCopy.GetStatistics();

            Assert.Equal(50, Result.Low);
            Assert.Equal(100, Result.High);
            Assert.Equal(75, Result.Average);

        }
    }
}
