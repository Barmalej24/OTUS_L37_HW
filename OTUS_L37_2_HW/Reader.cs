using System.Collections.Concurrent;
using System.Text;

namespace OTUS_L37_2_HW
{
    internal class Reader
    {
        private ConcurrentDictionary<string, int> _books;
        public Reader()
        {
            _books = new ConcurrentDictionary<string, int>();

            Task.Run(async () =>
            {
                while (true)
                {
                    foreach (var book in _books)
                    {
                        if (book.Value == 100)
                        {
                            _books.TryRemove(book.Key, out var v);
                        }
                        else
                        {
                            _books.AddOrUpdate(book.Key, book.Value, (key, oldValue) => oldValue + 1);
                        }
                    }

                    await Task.Delay(1000);
                }
            });
        }

        public void Add(string nameBook)
        {
            var resultAdd = _books.TryAdd(nameBook, 0);
            if (resultAdd == false)
            {
                throw new Exception();
            }
        }

        public void PrintAllBooks() 
        {
            var sb = new StringBuilder();

            sb.AppendLine("+++++++++++++++++++++++++++++++++++++++++");

            if (_books.Count == 0)
            {
                sb.AppendLine("            Список книг пуст");
            }
            foreach (var book in _books)
            {
                sb.AppendLine($"# {book.Key} - {book.Value}%");
            }

            sb.AppendLine("+++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(sb.ToString());
        }
    }
}
