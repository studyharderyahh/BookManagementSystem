using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class Book
    {
        // Properties
        public string ISBN { get; set; }
        public List<string> AuthorsName { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public int ReleasedYear { get; set; }
        public string Category { get; set; }

        // Constructor
        public Book(string isbn, List<string> authorsName, string bookName, string publisher, int releasedYear, string category)
        {
            ISBN = isbn;
            AuthorsName = authorsName;
            BookName = bookName;
            Publisher = publisher;
            ReleasedYear = releasedYear;
            Category = category;
        }

        // Override ToString method to represent a Book object as a string
        public override string ToString()
        {
            // Join authors with colon if there are multiple authors
            string authorName = AuthorsName.Count > 1 ? string.Join(":", AuthorsName) : AuthorsName[0];
            return $"{ISBN}, {authorName}, {BookName}, {Publisher}, {ReleasedYear}, {Category}";
        }
    }
}
