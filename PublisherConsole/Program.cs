using PublisherData;
using PublisherDomain;
using Microsoft.EntityFrameworkCore;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();

} 
// // GetAuthors();
// AddAuthor();
// GetAuthors();
// AddAuthorWithBook();
GetAuthorsWithBooks();

void AddAuthorWithBook()
{
    var author = new Author {FirstName = "Julie", LastName = "Leman"};
    author.Books.Add(new Book { 
        Title = "Programming Entity Framework",
        PublisherDate = new DateTime(2009, 1,1)
    });
    author.Books.Add(new Book {
        Title = "Programming Entity Framework 2nd Ed",
        PublisherDate = new DateTime(2010,8,1)
    });
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();

}

void GetAuthorsWithBooks()
{
    using var context = new PubContext();
    var authors = context.Authors.Include(a=>a.Books).ToList();
    foreach (var author in authors)
    {
        System.Console.WriteLine(author.FirstName + " " + author.LastName);
        foreach (var book in author.Books)
        {
            System.Console.WriteLine("*" + book.Title);
        }        
    }


}

void AddAuthor()
{
    var author = new Author { FirstName= "Serena", LastName= "Supergirl" };
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        System.Console.WriteLine(author.FirstName + " " + author.LastName);
    }
}

