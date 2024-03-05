namespace task3;

public class Book :AbstractBook,IBorrowable
{
    public void Borrow()
    {
        System.Console.WriteLine("Book has been borrowed.");
    }
    public void ReturnBook()
    {
        System.Console.WriteLine("Book has been returned.");
    }
     public override void  Read()
    {
        System.Console.WriteLine("Book is being read.");
    }

}
