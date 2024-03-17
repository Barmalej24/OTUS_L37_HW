using System.Collections.ObjectModel;
using System.Text;

namespace OTUS_L37_1_HW
{
    public class Shop
    {
        public ObservableCollection<Item> Items;
        private int _count = 0;
        public Shop() => Items = new ObservableCollection<Item>();

        public void Add(string name)
        {
            var tempItem = new Item(_count, name);
            Items.Add(tempItem);
            _count++;
        }
        public void Remove(uint itemId)
        {
            var tempItem = Items.FirstOrDefault(x => x.Id == itemId);

            if (tempItem != null)
            {
                Items.Remove(tempItem);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void PrintAllItems()
        {
            var sb = new StringBuilder();

            sb.AppendLine("+++++++++++++++++++++++++++++++++++++++++");

            if(Items.Count == 0)
            {
                sb.AppendLine("            Список товаров пуст");
            }
            foreach (var item in Items)
            {
                sb.AppendLine($"# {item.Id} - {item.Name}");
            }

            sb.AppendLine("+++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(sb.ToString());
        }
    }
}
