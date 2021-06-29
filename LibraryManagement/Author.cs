namespace LibraryManagement
{
    class Author
    {
        private string authorName;
        private string authorEmail;
        private char authorGender;

        public Author() { }
        public Author(string authorName, string authorEmail, char authorGender)
        {
            this.setAuthorName(authorName);
            this.setAuthorEmail(authorEmail);
            this.setAuthorGender(authorGender);
        }

        public void setAuthorName(string authorName)
        {
            this.authorName = authorName;
        }
        public void setAuthorEmail(string authorEmail)
        {
            this.authorEmail = authorEmail;
        }
        public void setAuthorGender(char authorGender)
        {
            this.authorGender = authorGender;
        }

        public string getAuthorName()
        {
            return this.authorName;
        }
        public string getAuthorEmail()
        {
            return this.authorEmail;
        }
        public char getAuthorGender()
        {
            return this.authorGender;
        }

        public override string ToString()
        {
            return "Author Name: " + this.getAuthorName() + "\t|\t" + "Author Email: " + this.getAuthorEmail() + "\t|\t" + "Author Gender: " + this.getAuthorGender();
        }

    }
}
