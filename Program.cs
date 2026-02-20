using System;
namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("");
            Book book2 = new Book("");
            Book book3 = new Book("");
                bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine();
                Console.WriteLine("1. Display all books");
                Console.WriteLine("2. update one book");
                Console.WriteLine("3. Exite");
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
                        Console.Write("Select book (1-3): ");
                        int bookSelection = Convert.ToInt32(Console.ReadLine());
                        switch (bookselection)
                        {
                            case 1:
                                book1.ToggleComplete();
                                Console.WriteLine(" Book 1 update. ");
                                break;
                            case 2:
                                book2.ToggleComplete();
                                Console.WriteLine(" Book 2 update. ");
                                break;
                            case 3:
                                book3.ToggleComplete();
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
