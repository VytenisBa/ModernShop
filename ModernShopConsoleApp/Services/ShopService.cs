using ModernShopConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernShopConsoleApp.Services
{
    public class ShopService
    {
        private List<ShopItem> _items;

        public ShopService()
        {
            _items = new List<ShopItem>();
        }

        public void Add(string name, string price, string quantity)
        {
            var item = new ShopItem()
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };
            bool doesExst = !_items.Any(x => x.Name == name);  //ar bent vienas itemas is mano saraso jau yra? ir paverciam neiginiu '!'
            if (doesExst)
                _items.Add(item);
            else Console.WriteLine("Such item alredy exist (try 'Set' for same tipe of items)");
        }
        public List<ShopItem> GetAll()
        {
            return _items;
        }

        public void Remove(string name)
        {
            _items = _items.Where(x => x.Name != name).ToList();

        }

        public void Set(string name, string price, string quantity)
        {
            ShopItem firstShopItems = _items.First(x => x.Name == name);  //suradom itema
            firstShopItems.Quantity = quantity;  //atnaujina quantity          

        }
    }
}
