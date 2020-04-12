namespace Lesson01_LW02
{
    class Library
    {
        private Book book;

        public Book Book
        {
            get { return book; }
        }
        public Library()
            :this("Василий М. Фломастер", "Как я подоил улитку.")
        {
            
        }
        public Library(string author, string bookName)
        {
            book = new Book();
            book.Author = author;
            book.BookName = bookName;
        }

    }
}
