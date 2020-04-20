namespace Lesson05_pdfHW04
{
    class Article
    {
        public string Title { get; private set; }
        public double Price { get; set; }
        public string StoreName { get; private set; }
        public Article(string title, double price)
        {
            Title = title;
            Price = price;
            
        }
        public Article(string title, double price, string storename)
            : this (title,price)
        {
            StoreName = storename;
        }
    }
}
