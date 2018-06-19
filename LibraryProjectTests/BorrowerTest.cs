using System;
using System.Collections;
using LibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BorrowerTest
{
    [TestClass]
    public class BorrowerTest
    {

        Borrower borrower;
        Book book;
        ArrayList bookArray;
        Library library;

        [TestInitialize]
        public void Initialize()
        {
            borrower = new Borrower("Marky T");
            book = new Book("Let The Right One In", "John Ajvide Lindqvist");
            bookArray = new ArrayList();
            bookArray.Add(book);
            library = new Library(bookArray, "Fountainbridge Library", 25);
        }

        [TestMethod]
        public void TestBorrowerHasName()
        {
            Assert.AreEqual("Marky T", borrower.GetName());
        }

        [TestMethod]
        public void TestBorrowedBooksStartsEmpty()
        {
            Assert.AreEqual(0, borrower.CountBorrowedBooks());
        }

        [TestMethod]
        public void TestCanAddToBorrowedBooks()
        {
            borrower.BorrowBook(library, book);
            Assert.AreEqual(1, borrower.CountBorrowedBooks());
        }

        [TestMethod]
        public void TestCanRemoveFromBorrowedBooks()
        {
            borrower.BorrowBook(library, book);
            borrower.ReturnBook(library, book);
            Assert.AreEqual(0, borrower.CountBorrowedBooks());
        }
    }
}