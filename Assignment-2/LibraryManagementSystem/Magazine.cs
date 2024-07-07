public class Magazine : Book
{
    public static int IssueNumber { get; set; }

    public Magazine(string author) : base(author) { }

    public void Subscribe()
    {
        Console.WriteLine("Subscribing to the magazine.");
    }

    public override void Read()
    {
        Console.WriteLine("Reading the magazine.");
    }
}
