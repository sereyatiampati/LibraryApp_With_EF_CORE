using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherDomain
{
    public class Author
    {
        public Author()
        {
            Books = new List <Book>();
        } 

        public List<Book> Books { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
    }
}