using System;

namespace Lesson05_pdfHW04
{
    class Store
    {
        private readonly string storeName;
        private int count;
        Article[] articles = new Article[4];
        public int Length { get { return count; } }

        public Store(string storename)
        {
            this.storeName = storename;
        }
        public Store(string storename, params Article[] articles)
            : this(storename)
        {
            for (int i = 0; i < articles.Length; i++)
            {
                AddItem(articles[i].Title, articles[i].Price);
            }
        }
        public Article this[int index]
        {
            get
            {
                if (index > -1 && index < articles.Length)
                {
                    return articles[index];
                }
                return null;
            }
        }
        public Article this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i]?.Title == index)
                    {
                        return articles[i];
                    }
                }
                Console.WriteLine("Такого товара не найдено");
                return null;
            }
        }
        public void AddItem(string title, double price)
        {
            if (!(count < articles.Length))
                Resize();

            articles[count] = new Article(title, price, storeName);
            count++;
        }
        public void GetArticleInformation()
        {
            Console.WriteLine($"Название Магазина \"{storeName}\"\n" +
              new string('-', 50) + "\n");

            for (int i = 0; i < articles.Length;i++)
            {
                if (articles[i]!= null)
                {
                    Console.WriteLine($"{i + 1}. \"{articles[i].Title}\"  -   {articles[i].Price} гривен");
                }
            }
        }
        public void RemoveItem(int index)
        {
            Article[] temp = new Article[articles.Length];
            int j = 0;

            for (int i = 0; i < articles.Length; i++)
            {
                if (i != index)
                {
                    temp[j++] = articles[i];
                }
            }
            while (j < temp.Length)
            {
                temp[j++] = null;
            }

            articles = temp;
        }
        #region private Methods
        private void Resize()
        {
            Article[] temp = new Article[articles.Length * 2];
            for (int i = 0; i < articles.Length; i++)
            {
                temp[i] = articles[i];
            }
            articles = temp;
        }

        #endregion
    }
}
