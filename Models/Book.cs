using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliosharp.Models
{
    public class Book
    {
        public int id;
        public string Title;
        public int Author;
        public string Isbn;
        public int Category;

        //constructors
        public Book(string title,string isbn, Category Category, Author Author){
            Title=title;
            this.Author= Author.Id;
            this.Category=Category.Id;
            Isbn=isbn;

        }
         public Book(string title,string isbn, int Category, int Author){
            Title=title;
            this.Author= Author;
            this.Category=Category;
            Isbn=isbn;

        }
    }
}