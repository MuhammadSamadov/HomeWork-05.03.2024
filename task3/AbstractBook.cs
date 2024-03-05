namespace task3;

public abstract class AbstractBook : IReadable
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public void SetTitle(string title)
    {
        Title=title;
    }
    public void SetAuthor(string author)
    {
        Author=author;
    }
    public virtual void Read()
    {
        System.Console.WriteLine("Book is being read.");
    }
}
