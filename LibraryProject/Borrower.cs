using System;
using System.Collections;

namespace LibraryProject
{
    public class Borrower
    {

        private readonly string _name;
        private ArrayList _borrowedBooks = new ArrayList();

        public Borrower(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public int CountBorrowedBooks()
        {
            return _borrowedBooks.Count;
        }

        public void BorrowBook(Library library, Book book)
        {
            _borrowedBooks.Add(library.RemoveBook(book));
        }

        public void ReturnBook(Library library, Book book)
        {
            _borrowedBooks.Remove(book);
            library.AddBook(book);
        }
    }
}
