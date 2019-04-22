using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;
        private static int bookCount;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            bookCount++;
        }

        static Book()
        {
            bookCount = 0;
        }

        public string GetTitle()
        {
            if (title != null && title.Length > 0)
            {
                return title;
            }
            else
            {
                return null;
            }
        }

        public string GetAuthor()
        {
            if (author != null && author.Length > 0)
            {
                return author;
            }
            else
            {
                return null;
            }
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
        public int GetTitleLength()
        {
            return title.Length;
        }

        public static int GetBookCount() => bookCount;

        // Or use lambda instead of {}, to save lines, like in the line below:
        // public int GetTitleLength() => title.Length;

        // Static é apenas acessível a partir da classe e não de instâncias
        // não tendo então acesso a variáveis de instâncias nem incovar métodos
        // de instâncias (abaixo um exemplo do mesmo)
        public static int maxPages;
    }
}