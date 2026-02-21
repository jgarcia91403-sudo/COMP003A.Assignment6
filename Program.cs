using System;
namespace COMP003A.Assignment6
{
    class Book
    {
        public string Title;
        public int pages;
        public bool Completed;
        public Book(string title, int Pages, bool completed)
        {
            Title = title;
            pages = Pages;
            Completed = completed;
        }
        public void DisplayBook()
        {
            Console.WriteLine(" Title:" + Title + ", Pages:" + pages + ", Completed:" + Completed);
        }
        public void ToggleCompleted()
        {
            Completed = !Completed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Atomic Habits", 320, false);
            Book book2 = new Book("clean code", 464, true);
            Book book3 = new Book("The pragmatic Programer", 352, false);
                bool exitProgram = false;
                Console.WriteLine();
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. update one book");
                Console.WriteLine("3. Exite");
            while (!exitProgram)
            {
                Console.WriteLine();
                Console.Write("Enter choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine(" Book 1:");
                        book1.DisplayBook();
                        Console.WriteLine(" Book 2:");
                        book2.DisplayBook();
                        Console.WriteLine(" Book 3:");
                        book3.DisplayBook();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Select book (1-3): ");
                        int bookSelection = Convert.ToInt32(Console.ReadLine());
                        switch (bookSelection)
                        {
                            case 1:
                                book1.ToggleCompleted();
                                Console.WriteLine(" Book 1 update. ");
                                break;
                            case 2:
                                book2.ToggleCompleted();
                                Console.WriteLine(" Book 2 update. ");
                                break;
                            case 3:
                                book3.ToggleCompleted();
                                Console.WriteLine(" Book 3 update. ");
                                break;

                        }
                        break;
                    case 3:
                        exitProgram = true;
                        Console.WriteLine("Program ended.");
                        break;
                }
            }
        }
    }
}
