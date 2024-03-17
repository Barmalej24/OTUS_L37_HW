using System;
using System.Text;

namespace OTUS_L37_2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            var reader = new Reader();

            var key = Console.ReadKey();

            Console.WriteLine();

            while (true)
            {
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:                        
                        try
                        {
                            reader.Add(SetNewBook());
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Невозможно добавить книгу с пустым названием");
                        }
                        catch
                        {
                            PrintMenu();
                        }
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        reader.PrintAllBooks();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        return;

                    default:
                        Console.WriteLine("Выбранной команды нет");
                        break;
                }

                key = Console.ReadKey();

                Console.WriteLine();
            }
        }

        private static string SetNewBook()
        {
            Console.WriteLine("Введите название книги:");
            var name = Console.ReadLine();

            if(name == "") 
            {
                throw new ArgumentNullException();
            }

            return (name!);
        }

        private static void PrintMenu()
        {
            var sb = new StringBuilder();

            sb.AppendLine("_______________Меню______________");
            sb.AppendLine("1 - добавить книгу");
            sb.AppendLine("2 - вывести список непрочитанного");
            sb.AppendLine("3 - выйти");
            sb.AppendLine("---------------------------------");

            Console.WriteLine(sb.ToString());
        }
    }
}
