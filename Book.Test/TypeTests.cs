using Book.Core;
using System;
using Xunit;

namespace Book.Test
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            //the Obj Already called

            //Act
            var book1 = GetBookName("book 1");
            var book2 = GetBookName("book 2");

            //Asserts
            Assert.Equal("book1", book1.Name);
            Assert.Equal("book 2", book2.Name);



        }

        //Method to check the Name match.
        BookClass GetBookName(string name)
        {
            return new BookClass(name);
        }
    }
}
