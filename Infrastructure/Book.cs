using System.ComponentModel;
using System;

namespace Infrastructure
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Author> Authors { get; set; }

        public Book()
        {
            Authors = new List<Author>();
        }

        public string NameSubstring { get {return String.IsNullOrEmpty(Name)? String.Empty : Name.Substring(0,20); } }
    }
}