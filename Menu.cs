class Menu
{
    ShopBase shopBase;

    public Menu(ShopBase ShopBase)
    {
        shopBase = ShopBase;
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
                    Shop newShop = new Shop(0, "", "", "");
                    shopBase.AddShop(newShop);
                    break;
                }

            case "2":
                {
                    Console.WriteLine();
                    Console.WriteLine("Удалить магазин из базы");
                    shopBase.RemoveShop();
                    break;
                }

            case "3":
                {
                    Console.WriteLine();
                    Console.WriteLine("Вывести информацию о всех магазинах");
                    shopBase.PrintShops();
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