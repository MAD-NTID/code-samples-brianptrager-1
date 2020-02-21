using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_CSharp
{
    class Book : IPurchasable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Cost { get; set; }

        public Book()
        {
            this.Title = "No Title";
            this.Author = "N/A";
            this.Genre = "What?";
        }

        public string Purchase()
        {
            return $"You purchased {Title} written by {Author}, which is a {Genre} category for a price of {Cost:C}";
        }
    }
}
