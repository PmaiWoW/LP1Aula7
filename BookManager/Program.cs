using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            int bookNum;
            string title, author;
            Book[] books;

            // Pedir ao utilizador o nº de livros que quer
            Console.WriteLine("How many books do you want?");
            bookNum = Convert.ToInt32(Console.ReadLine());

            // Inicializar o array books
            books = new Book[bookNum];

            // Cicle for que pergunta para cada livro o seu título e autor e
            // os mostra ao utilizador
            for(int i = 0; i < bookNum; i++)
            {
                Console.WriteLine("\nInsert the book's title:");
                title = Console.ReadLine();
                Console.WriteLine("\nInsert the book's author:");
                author = Console.ReadLine();
                // Criar o objeto book com o título e autor dados
                Book book = new Book(title, author);
                // Guardar o objeto book criado no array de objetos book 
                // (books) com o título e autor dados
                books[i] = book;
            }

            // Para cada objeto book no array books, mostrar o título e autor
            for(int i = 0; i < books.Length; i++)
            {

                Console.WriteLine($"\nTitle: {books[i].GetTitle()}" +
                    $"(Title Length: {books[i].GetTitle().Length})");
                Console.WriteLine($"Author: {books[i].GetAuthor()}\n");
            }

            Console.WriteLine($"Number of books created: " +
                $"{Book.GetBookCount()}\n");

            /* Exemplo do pdf de aula
            Book book = new Book("Harry ", "J.K Rowling");

            // Change name of book after creating it
            book.SetTitle("Harry Potter and the Chamber of Secrets");

            // Damn, what was the title?
            Console.WriteLine(book.GetTitle());
            */
        }
    }
}
