using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> Storage { get; set; }

        public int Count { get; set; }

        public Library()
        {
            Storage = new Dictionary<string, Book>();
            Book Book1 = new Book("Captain Underpants", "Georleshia");
            Storage.Add(Book1.Title, Book1);
        }

        public void Add(string title, string author)
        {
            Book newBook = new Book(title, author);

            Storage.Add(newBook.Title, newBook);
            var result = Storage.Keys;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            var result = Storage.Values;
            foreach (Book book in result)
            {
                yield return book;
            }
        }

        public Book Borrow(string title)
        {
            Book returnedBook = Storage.GetValueOrDefault(title);
            Storage.Remove(returnedBook.Title);
            return returnedBook;
        }
        public void Return(Book book)
        {
            Storage.Add(book.Title, book);
        }


        public Book Search(string title)

        {
            bool result = Storage.ContainsKey(title);
            if (result == true)
            {
                return Storage[title];
            }
            return null;
        }

        public void ViewAllBooks()
        {
            var keys = Storage.Keys;
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys.ElementAt(i);
                Console.WriteLine(key);

            }

        }
    }

}
