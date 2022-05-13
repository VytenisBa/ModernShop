// See https://aka.ms/new-console-template for more information

using ModernShopConsoleApp.Services;

var applicationService = new ApplicationService();

Console.WriteLine("Options:\n Add < ShopItemName > < Price > < quantity >\n Remove < ShopItemName >\n Show inventory\n Set < ShopItemName > < quantity >\n " +
"Show balance\n Topup < sum >\n Show items\n Buy < ShopItemName > < Quantity >\n Exit \n");

while (true)
{
    Console.WriteLine("Enter your command:\n");
    try
    {
        var command = Console.ReadLine();
        applicationService.Process(command);
    }
    catch (Exception)
    {

        Console.WriteLine("Erorr"); ;
    }
  
}
