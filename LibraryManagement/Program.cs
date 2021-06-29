using System;

namespace LibraryManagement
{
    class Program
    {
        public static void showMenu()
        {
            Console.WriteLine("...Menu...");
            Console.WriteLine("1. Add Book with menu");
            Console.WriteLine("2. Add Book no menu");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. View Books");
            Console.WriteLine("5. View Authors");
            Console.WriteLine("6. Update Book Details");
            Console.WriteLine("...Anything else to exit...");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of racks in the Library: ");
            int n = Console.Read();
            Console.ReadLine();
            int menuInput;
            BookManagement obj = new BookManagement(n);
            while (true)
            {
                showMenu();
                try
                {
                    menuInput = Int32.Parse(Console.ReadLine());
                }
                catch (Exception E) {
                    menuInput = 0;
                }
                switch (menuInput)
                {
                    case 1:
                        obj.addBook();
                        break;
                    case 2:
                        obj.addBook(Console.ReadLine(), Console.ReadLine(), Console.Read(), Console.Read(), new Author(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()[0]));
                        break;
                    case 3:
                        obj.searchBook();
                        break;
                    case 4:
                        obj.viewBooks();
                        break;
                    case 5:
                        obj.viewAuthors();
                        break;
                    case 6:
                        obj.updateBooks();
                        break;
                    default:
                        Console.WriteLine("\n\nClosing...");
                        return;
                }
                Console.WriteLine("\n\nPress enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
