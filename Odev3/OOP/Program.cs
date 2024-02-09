using OOP.Concrete;
using OOP.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IBookServices bookServices = new BookManager();
        Console.WriteLine($"Kitap adı :{bookServices.GetBookTitle()}");
        Console.WriteLine($"Kitap Kategorisi :{bookServices.GetBookCategory()}");
        Console.WriteLine($"Kitap Sayfa Sayısı :{bookServices.GetPageCount()}");


        IAuthorServices authorServices = new AuthorManager();
        Console.WriteLine($"Yazar Adı : {authorServices.GetFullName()}");
        Console.WriteLine($"Yazar Dogum Tarihi : {authorServices.GetBirthDate()}");
        Console.WriteLine($"Yazar Email : {authorServices.GetEmail()}");
        Console.WriteLine($"Yazarın son kitabı : {authorServices.GetLastBook()}");
        Console.WriteLine($"Yazar son kıtabının tarihi : {authorServices.GetLastBookDate()}");

    }
}
