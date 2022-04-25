using System;

namespace _02._Articles
{
    class Article

    {
        private string title_;
        private string content_;
        private string author_;
        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Cotent = content;
        }
        public string Title
        {
            get => title_;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException(message: "The value can't be bull");
                }
                title_ = value;
            }
        }
        public string Cotent
        {
            get => content_;
            set => content_ = value;
        }
        public string Author
        {
            get => author_;
            set => author_ = value;
        }

        public void Edit(string content) => Cotent = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;

        public override string ToString()
        {
            return $"{Title} - {Cotent}: {Author}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                string[] initialArticle = Console.ReadLine().Split(separator: ", ");
                Article article = new Article(title: initialArticle[0], content: initialArticle[1], author: initialArticle[2]);
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] cmd = Console.ReadLine().Split(separator: ": ");
                    string mainCmd = cmd[0];
                    string argument = cmd[1];
                    switch (mainCmd)
                    {
                        case "Edit":
                            article.Edit(argument);
                            break;
                        case "ChangeAuthor":
                            article.ChangeAuthor(argument); break;
                        case "Rename":
                            article.Rename(argument);
                            break;

                    }
                }
                Console.WriteLine(article);


            }

        }
    }
}


