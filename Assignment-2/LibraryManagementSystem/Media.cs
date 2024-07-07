public abstract class Media
{
    public string Title { get; set; }
    public string Author { get; private set; }
    public string ISBN  { get; set; }

    public Media(string author)
    {
        Author = author;
    }

    public abstract void GetInfo();
}
