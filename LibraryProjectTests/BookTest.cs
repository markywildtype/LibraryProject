using System;
using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookTest
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void TestBookHasTitle()
        {
            Book book = new Book("The Joy of Sex", "Alex Comfort");

            Assert.AreEqual("The Joy of Sex", book.GetTitle());
        }
    }
}