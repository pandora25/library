using Book.Core;
using System;
using Xunit;

namespace Book.Test
{
    public class TypeTests
    {
        [Fact]
        public void CChasrpPassByValue()
        {
            var book1 = GetBookName("book 1");
            GetBookSetName(book1, "New Book");
            Assert.Equal("new name", book1.Name);
        }

        private void GetBookSetName(BookClass book, string name)
        {
            book = new BookClass(name);
            book.Name = name;
        }

        [Fact]
        public void CheckIfBookReturnDiffrentNAmeObj()
        {
            //Arrange
            //the Obj Already called

            //Act
            var book1 = GetBookName("book 1");
            var book2 = GetBookName("book 2");

            //Asserts
            Assert.Equal("book1", book1.Name);
            Assert.Equal("book 2", book2.Name);
            //Assert.NotSame("book 2", book2.Name);

        }
        //Method to check the Name match.
        BookClass GetBookName(string name)
        {
            return new BookClass(name);
        }

        [Fact]
        public void CheckIfBookReturnSameNAmeObj()
        {
            var book1 = GetBookName("book 1");
            var book2 = book1;
            Assert.True(object.ReferenceEquals(book1, book2));
        }
    }
}
