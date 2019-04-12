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

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
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
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}