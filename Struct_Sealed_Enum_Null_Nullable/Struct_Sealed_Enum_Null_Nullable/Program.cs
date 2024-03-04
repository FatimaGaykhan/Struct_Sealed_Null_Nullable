using Struct_Sealed_Enum_Null_Nullable;

//Book book = new Book();

//book.Name = "Fatya";
//Console.WriteLine(book.Name);

//Class1 class1 = new();
//class1.Num = 100;
//Console.WriteLine(class1.Num);

string name = null;
//Book book = new Book();
//Console.WriteLine(book.Id);

//if (book.Id==null)
//{
//    Console.WriteLine("Book id not found");
//}
Book book1 = new()
{
    Id = 1,
    Name = "Isgendername",
    Author=new Author() {  Id =2}
};
Book book2 = new()
{
    Id = 2,
    Name = "Xosrov ve Shirin "
};
//Console.WriteLine("Book:" + book2.Name + "    Author:" + book1.Author.Name?.Substring(1, 5));

//string data = null;
//data.Substring(1, 5);

//Book[] books = { book1, book2 };

//void GetBookById(Book[] books,int? id=null)
//{
//    if (id==null)
//    {
//        Console.WriteLine("Your Id Is Null");
//        return;
//    }
//    Book result = books.FirstOrDefault(m => m.Id == id);

//    Console.WriteLine(result.Name);

//}
//GetBookById(books,2);

//Level level = Level.Low;
//Console.WriteLine((int)level==1);

void GetLevel(string level)
{
    switch (level)
    {
        case nameof(Level.Low) :
            Console.WriteLine("Low");
            break;
        case nameof(Level.Middle):
            Console.WriteLine("Middle");
            break;
        case nameof(Level.High):
            Console.WriteLine("High");
            break;
        default:
            Console.WriteLine("Dogru daxil edilmeyib");
            break;
    }
}

GetLevel("Mjnfhesb");