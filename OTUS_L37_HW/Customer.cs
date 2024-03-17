using System.Collections.Specialized;

namespace OTUS_L37_1_HW
{
    public class Customer
    {
        private Shop _shop;

        public Customer(Shop shop)
        {
            this._shop = shop;
            this._shop.Items.CollectionChanged += OnItemChanged;
        }

        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Item newItem)
                        Console.WriteLine($"Добавлен новый объект: {newItem.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Item oldItem)
                        Console.WriteLine($"Удален объект: {oldItem.Name}");
                    break;
            }
        }
    }
}
