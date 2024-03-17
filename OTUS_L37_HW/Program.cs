namespace OTUS_L37_1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();

            var shop = new Shop();
            var cust1 = new Customer(shop);            
            var key = Console.ReadKey();

            Console.WriteLine();

            while (true)
            {
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        shop.Add($"Товар от {DateTime.Now}");
                        break;

                    case ConsoleKey.D:
                        shop.PrintAllItems();
                        try
                        {
                            Console.WriteLine("Введите номер товара:");
                            shop.Remove(Convert.ToUInt16(Console.ReadLine()));
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Указанный индекс товара не найден");
                            PrintMenu();
                        }
                        catch
                        {
                            Console.WriteLine("Указанный индекс не является числом");
                            PrintMenu();
                        }
                        break;

                    case ConsoleKey.X:
                        return;

                    default:
                        Console.WriteLine("Выбранной команды нет");
                        break;
                }

                key = Console.ReadKey();

                Console.WriteLine();
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("По нажатии клавиши A добавляйте новый товар в магазин");
            Console.WriteLine("По нажатии клавиши D удалить товар в магазине");
            Console.WriteLine("По нажатии клавиши X выход из программы");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
