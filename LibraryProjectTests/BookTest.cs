using System;
using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookTest
{
    [TestClass]
    public class BookTest
    {

        public Book book;

        [TestInitialize]
        public void Initialize()
        {
            book = new Book("The Joy of Sex", "Alex Comfort", "Sexytime Manual");
        }

        [TestMethod]
        public void TestBookHasTitle()
        {
            Assert.AreEqual("The Joy of Sex", book.GetTitle());
        }

        [TestMethod]
        public void TestBookHasGenre()
        {
            Assert.AreEqual("Sexytime Manual", book.Genre);
        }
    }
}