class Book
{
    public string title;
    public string author;
    public int year;

    public Book(string _title, string _author,int _year)
    {
      title = _title;
      author = _author;
      year = _year;
    }
    public void GetInfo()
    {
        System.Console.WriteLine("Title : " + title);
        System.Console.WriteLine("Муаллиф: " + author);
        System.Console.WriteLine("Соли нашр: " + year);
    }
    public bool IsPublishedRecently()
    {
       if (year > 2010)
       {
        return true;
       } 
       else return false;
    }
}