using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Library
    {
        private ArrayList _collection = new ArrayList();
        private readonly string _name;
        private readonly int _capacity;

        public Library(ArrayList collection, string name, int capacity)
        {
            _collection = collection;
            _name = name;
            _capacity = capacity;
        }

        public string GetName()
        {
            return _name;
        }

        public int CountCollection()
        {
            return _collection.Count;
        }

        public string AddBook(Book book)
        {
            if(!IsAtCapacity())
            {
                _collection.Add(book);
                return "Yay! Another copy of 'The Joy Of Sex!";
            }
            else
            {
                return "Go fuck yourself! We got enough books!";
            }
        }

        public Book RemoveBook(Book book)
        {
            _collection.Remove(book);
            return book;
        }


        public int GetCapacity()
        {
            return _capacity;
        }

        public bool IsAtCapacity()
        {
            return _capacity == CountCollection();
        }

        public int CountGenre(string genre)
        {
            Hashtable genreHash = new Hashtable();
            foreach(Book book in _collection)
            {
                if(!(genreHash[book.Genre] == null))
                {
                    genreHash[book.Genre] = (int)genreHash[book.Genre] + 1;
                }
                else
                {
                    genreHash[book.Genre] = 1;
                }
            }
            return (int)genreHash[genre];
        }
    }
}
