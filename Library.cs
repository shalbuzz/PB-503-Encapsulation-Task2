using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_2
{
    public class Library
    {
        Books[] books = new Books[0];

        public void AddBooks(Books book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }

        public Books GetBookById(int id)
        {

            foreach (var book in books)
            {
                if (book.Id == id) return book;

            }

            return null;

        }

        public Books GetBookByName(string name)
        {

            foreach (var book in books)
            {

                if (book.Name == name) return book;
            }

            return null;
        }


        public Books[] GetBooksByName(string name)
        {
            Books[] wantedBooks = new Books[0];
            foreach(var book in books)
            {
                if (book.Name.ToLower().Contains(name.ToLower())){

                    Array.Resize(ref wantedBooks, wantedBooks.Length + 1);
                    wantedBooks[wantedBooks.Length - 1]= book;
                }
            }
            return wantedBooks;
        }
        public Books[] GetFilteredBook(string value)
        {

            Books[] filteredBook = new Books[0];
            

            foreach (var book in books)
            {

                if (book.Genre == value) { 
                
                   Array.Resize(ref filteredBook, filteredBook.Length + 1);
                    filteredBook[filteredBook.Length - 1]= book;
                }

            }

            
          return filteredBook;
        }

        public Books[] GetFilteredBooks(double minPrice, double maxPrice)
        {

            Books[] filteredBooks = new Books[0];
           

            foreach(var book in books)
            {
                if (book.Price>=minPrice&&book.Price <= maxPrice)
                {
                   Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }

               
                
                
              }
            return filteredBooks;

        }
    }
}