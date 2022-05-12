using ModernShopConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernShopConsoleApp.Services
{
    public class ApplicationService
    {
        private ShopService _shopService;
        
        public ApplicationService()
        {
            _shopService = new ShopService();
        }

        public void Process(string command)
        {
            if(command.StartsWith("Add"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Add(splitCommand[1], splitCommand[2], splitCommand[3]);
            }

            if(command.StartsWith("Remove"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Remove(splitCommand[1]);
            }

            if(command.StartsWith("Show inventory"))
            {
                List<ShopItem> items = _shopService.GetAll();
                foreach (ShopItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemPrice: {item.Price} ItemQty: {item.Quantity}");
                }
            }

            if(command.StartsWith("Set"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Set(splitCommand[1], splitCommand[2], splitCommand[3]);
            }

            if(command.StartsWith("Show Balance"))
            {

            }

            if(command.StartsWith("Topup"))
            {

            }

            if(command.StartsWith("Show items"))
            {

            }

            if(command.StartsWith("Buy"))
            {

            }

            if (command.StartsWith("Exit"))
            {
                Console.WriteLine("Have a nice day!");
                Environment.Exit(1);
            }
        }
            
    }
}
