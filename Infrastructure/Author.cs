namespace Infrastructure
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
            //checked CS8618 - Non - nullable variable must contain a non - null value when exiting constructor. Consider declaring it as nullable.
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings?f1url=%3FappId%3Droslyn%26k%3Dk(CS8618)#nonnullable-reference-not-initialized
            //var t = Name.Contains('h');
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}