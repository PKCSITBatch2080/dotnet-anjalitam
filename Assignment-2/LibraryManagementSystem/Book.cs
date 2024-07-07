public class Book : Media, Loanable
{
    public string Publisher { get; set; }

    public Book(string author) : base(author) { }

    public virtual void Read()
    {
        Console.WriteLine("Reading the book.");
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Publisher: {Publisher}, ISBN: {ISBN}");
    }

    public void Borrow()
    {
        Console.WriteLine("The book has been borrowed.");
    }

    public void Return(DateTime returnDate)
    {
        Console.WriteLine($"The book is due back on {returnDate.ToShortDateString()}.");
    }
}
