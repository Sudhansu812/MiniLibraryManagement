namespace LibraryManagement
{
    class Book
    {
        private string bookId;
        private string bookName;
        private int bookYearPublication;
        private decimal bookPrice;
        private Author authorDetails;

        public Book() 
        {
            this.authorDetails = new Author();
        }
        public Book(string bookId, string bookName, int bookYearPublication, decimal bookPrice, Author authorDetails)
        {
            this.setBookId(bookId);
            this.setBookName(bookName);
            this.setBookYearPublication(bookYearPublication);
            this.setBookPrice(bookPrice);
            this.setAuthorDetails(authorDetails);
        }

        public void setBookId(string bookId)
        {
            this.bookId = bookId;
        }
        public void setBookName(string bookName)
        {
            this.bookName = bookName;
        }
        public void setBookYearPublication(int bookYearPublication)
        {
            this.bookYearPublication = bookYearPublication;
        }
        public void setBookPrice(decimal bookPrice)
        {
            this.bookPrice = bookPrice;
        }
        public void setAuthorDetails(Author authorDetails)
        {
            this.authorDetails = authorDetails;
        }

        public string getBookId()
        {
            return this.bookId;
        }
        public string getBookName()
        {
            return this.bookName;
        }
        public int getBookYearPublication()
        {
            return this.bookYearPublication;
        }
        public decimal getBookPrice()
        {
            return this.bookPrice;
        }
        public Author getAuthorDetails()
        {
            return this.authorDetails;
        }

        public override string ToString()
        {
            return "Book ID: " + this.getBookId() + "\t|\t" + "Book Name: " + this.getBookName() + "\t|\t" + "Book Publication Year: " + this.getBookYearPublication() + "\t|\t" + "Author Name: " +
                this.getAuthorDetails().getAuthorName() + "\t|\t" + "Price: " + this.getBookPrice();
        }

    }
}
