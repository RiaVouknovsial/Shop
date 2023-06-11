class Start
{
    ShopBase shopBase;
    Shop shop;

    public Start(ShopBase shopbase)
    {
        this.shopBase = shopbase;
    }

    public void ShowOptions()
    {
        Console.WriteLine();
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Добавить магазин в базу");
        Console.WriteLine("2 - Удалить магазин из базы");
        Console.WriteLine("3 - Вывести информацию о всех магазинах");
        Console.WriteLine("4 - Выйти из программы");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                {
                    Console.WriteLine();
                    Console.WriteLine("Добавить магазин в базу");
                    Console.WriteLine("Введите название магазина:");
                    string shopName = Console.ReadLine();
                    Console.WriteLine("Введите адрес магазина:");
                    string shopAddress = Console.ReadLine();
                    Console.WriteLine("Введите тип магазина:");
                    string shopType = Console.ReadLine();
                    Console.WriteLine("Введите номер магазина:");
                    string shopID = Console.ReadLine();
                    Shop newShop = new Shop(shopName, shopAddress, shopType, shopID);
                    this.shopBase.AddShop(newShop);
                    break;
                }

            case "2":
                {
                    Console.WriteLine();
                    Console.WriteLine("Удалить магазин из базы");
                    Console.WriteLine("Введите номер магазина для удаления:");
                    string shopID = Console.ReadLine();
                    shop = this.shopBase.FindShopById(shopID);
                    this.shopBase.RemoveShop(shop);
                    break;
                }

            case "3":
                {
                    Console.WriteLine();
                    Console.WriteLine("Вывести информацию о всех магазинах");
                    this.shopBase.PrintShops();
                    break;
                }

            case "4":
                {
                    Console.WriteLine();
                    Console.WriteLine("Для выхода из программы нажмите Escape");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    break;
                }

            default:
                {
                    Console.WriteLine();
                    Console.WriteLine("Неизвестная операция");
                    break;
                }
        }
    }
}
