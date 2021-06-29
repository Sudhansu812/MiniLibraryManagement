using System;

namespace LibraryManagement
{
    class BookManagement
    {
        private Book[] rack;
        private int numberOfBooks = 0;

        public BookManagement(int n)
        {
            this.rack = new Book[n];
        }
        public void takeInput(int i)
        {
            rack[i] = new Book();
            Console.WriteLine("Book Name: ");
            this.rack[i].setBookName(Console.ReadLine());
            Console.WriteLine("Book ID: ");
            this.rack[i].setBookId(Console.ReadLine());
            Console.WriteLine("Year Published: ");
            this.rack[i].setBookYearPublication(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Price: ");
            this.rack[i].setBookPrice(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Author Details:");
            Console.WriteLine("Author Name: ");
            this.rack[i].getAuthorDetails().setAuthorName(Console.ReadLine());
            Console.WriteLine("Author Email: ");
            this.rack[i].getAuthorDetails().setAuthorEmail(Console.ReadLine());
            Console.WriteLine("Author Gender: ");
            this.rack[i].getAuthorDetails().setAuthorGender(Console.ReadLine()[0]);
        }
        public void addBook()
        {
            this.takeInput(numberOfBooks);
            numberOfBooks++;
        }
        public void addBook(string bookId, string bookName, int bookYearPublication, decimal bookPrice, Author authorDetails)
        {
            this.rack[numberOfBooks] = new Book(bookId, bookName, bookYearPublication, bookPrice, authorDetails);
            numberOfBooks++;
        }
        public int searchBook()
        {
            string input;
            Console.WriteLine("Through Book name or ID: ");
            input = Console.ReadLine();

            for (int i = 0; i < numberOfBooks; i++)
            {
                if (this.rack[i].getBookName().Equals(input) || this.rack[i].getBookId().Equals(input))
                {
                    return i;
                }
            }

            return -1;
        }
        public void viewBooks()
        {
            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine((i + 1) + "___");
                Console.WriteLine(this.rack[i].ToString());
                Console.WriteLine("______");
            }
        }
        public void viewAuthors()
        {
            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine((i + 1) + "___");
                Console.WriteLine(this.rack[i].getAuthorDetails().ToString());
                Console.WriteLine("______");
            }
        }
        public void updateBooks()
        {
            int i = this.searchBook();
            if (i >= 0)
            {
                this.takeInput(i);
            }
            else
            {
                Console.WriteLine("Book Not Found!!!");
            }
        }

    }
}
