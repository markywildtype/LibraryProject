using System;
using System.Collections;
using LibraryProject;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryProjectTests
{
    [TestClass]
    public class LibraryTest
    {
        Library library;
        Book book;
        Book book2;
        ArrayList bookArray;
        Borrower borrower;

        [TestInitialize]
        public void Initialize()
        {
            book = new Book("The Joy of Sex", "Alex Comfort", "Sexytime Manual");
            book2 = new Book("They Joy of Sex", "Alex Comforter", "Sexytime Manual");
            bookArray = new ArrayList();
            bookArray.Add(book);
            library = new Library(bookArray, "Ciaran and Marky's Wonder Library", 10);
            borrower = new Borrower("Marky T");
        }

        [TestMethod]
        public void TestLibraryHasName()
        {
            Assert.AreEqual("Ciaran and Marky's Wonder Library", library.GetName());
        }

        [TestMethod]
        public void TestLibraryHasCollection()
        {
            Assert.AreEqual(1, library.CountCollection());
        }

        [TestMethod]
        public void TestCanAddBookToLibrary()
        {
            library.AddBook(book2);

            Assert.AreEqual(2, library.CountCollection());
        }

        [TestMethod]
        public void TestLibraryHasCapacity()
        {
            Assert.AreEqual(10, library.GetCapacity());
        }

        [TestMethod]
        public void TestLibraryIsAtCapacity()
        {
            Assert.AreEqual(false, library.IsAtCapacity());
            foreach (int num in Enumerable.Range(1, 9))
            {
                library.AddBook(new Book("The Joy of Sex", "Alex Comfort", "Sexytime Manual"));
            }
            Assert.AreEqual(true, library.IsAtCapacity());
        }

        [TestMethod]
        public void TestCannotAddBookIfAtCapacity()
        {
            foreach (int num in Enumerable.Range(1, 9))
            {
                library.AddBook(new Book("The Joy of Sex", "Alex Comfort", "Sexytime Manual"));
            }
            Assert.AreEqual(true, library.IsAtCapacity());
            library.AddBook(book2);
            Assert.AreEqual(10, library.CountCollection());
            Assert.AreEqual("Go fuck yourself! We got enough books!", library.AddBook(book2));
        }

        [TestMethod]
        public void TestCanRemoveBook()
        {
            Book bookToRemove = new Book("The Road", "Cormac McCarthy", "Dystopian");
            library.AddBook(bookToRemove);
 
            Assert.AreEqual(2, library.CountCollection());

            library.RemoveBook(bookToRemove);

            Assert.AreEqual(1, library.CountCollection());
        }

        [TestMethod]
        public void TestBorrowerCanBorrowBook()
        {
            library.AddBook(book2);
            Assert.AreEqual(2, library.CountCollection());
            Assert.AreEqual(0, borrower.CountBorrowedBooks());
            borrower.BorrowBook(library, book);
            Assert.AreEqual(1, library.CountCollection());
            Assert.AreEqual(1, borrower.CountBorrowedBooks());
        }

        [TestMethod]
        public void TestBorrowerCanReturnBook()
        {
            borrower.ReturnBook(library, book2);
            Assert.AreEqual(2, library.CountCollection());
        }

        [TestMethod]
        public void TestCanCountByGenre()
        {
            library.AddBook(book2);
            library.AddBook(new Book("Let The Right One In", "John Ajvide Lindqvist", "Horror"));
            Assert.AreEqual(2, library.CountGenre("Sexytime Manual"));
            Assert.AreEqual(1, library.CountGenre("Horror"));
        }

    }
}
