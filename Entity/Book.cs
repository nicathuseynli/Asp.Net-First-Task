namespace Asp.Net_Task.Entity
{
    public class Book
    {
        public string Id { get; set; }
        public string BookName { get; set; }=string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; }=string.Empty ;
        public string Author { get; set; }= string.Empty ;


        public Book(string id, string bookname, decimal price, string category, string author)
        {
            Id = id;
            BookName = bookname;
            Price = price;
            Category = category;
            Author = author;
        }
    }
}
