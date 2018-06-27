using System;

namespace LibraryProject
{
    public class Book
    {

        private readonly string _title;
        private readonly string _author;

        public string Genre;

        public Book(string title, string author, string genre)
        {
            _title = title;
            _author = author;
            Genre = genre;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }
    }
}