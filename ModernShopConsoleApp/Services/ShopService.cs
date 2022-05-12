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

            _items.Add(item);
        }
        public List<ShopItem> GetAll()
        {
            return _items;
        }

        public void Remove(string name)
        {
            _items = _items.Where(x => x.Name != name).ToList();

        }
    }
}
