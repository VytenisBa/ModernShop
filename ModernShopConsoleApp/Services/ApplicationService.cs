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
            if(command.StartsWith("add"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Add(splitCommand[1], splitCommand[2], splitCommand[3]);
            }



            else if (command.StartsWith("remove"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Remove(splitCommand[1]);
            }


            else if (command.StartsWith("show inventory"))
            {
                List<ShopItem> items = _shopService.GetAll();
                foreach (ShopItem item in items)
                {
                    Console.WriteLine($"ItemName: {item.Name} ItemPrice: {item.Price} ItemQty: {item.Quantity}");
                }
            }

            else if (command.StartsWith("set"))
            {
                string[] splitCommand = command.Split(" ");
                _shopService.Set(splitCommand[1], splitCommand[2], splitCommand[3]);
            }


            else if (command.StartsWith("show balance"))
            {

            }

            else if (command.StartsWith("topup"))
            {

            }

            else if (command.StartsWith("show items"))
            {

            }

            else if (command.StartsWith("buy"))
            {

            }

            else if (command.StartsWith("exit"))
            {
                Console.WriteLine("Have a nice day!");
                Environment.Exit(1);
            }

            else
            {
                Console.WriteLine("Erorr");
            }

        }
            
    }
}
