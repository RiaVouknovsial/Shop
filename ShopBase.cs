class ShopBase : IDisposable
{
    public List<Shop> shops;

    public ShopBase()
    {
        shops = new List<Shop>();
    }

    public void AddShop(Shop shop)
    {
        shops.Add(shop);
        Console.WriteLine($"Магазин '{shop.ShopName}' успешно добавлен в базу данных.");
    }

    public void RemoveShop(Shop shop)
    {
        if (shops.Remove(shop))
        {
            Console.WriteLine($"Магазин '{shop.ShopName}' успешно удален из базы данных.");
        }
        else
        {
            Console.WriteLine($"Магазин '{shop.ShopName}' не найден в базе данных.");
        }
    }

    public Shop FindShopById(string shopID)
    {
        return shops.Find(shop => shop.ShopID == shopID);
    }

    public void PrintShops()
    {
        foreach (Shop shop in shops)
        {
            Console.WriteLine(shop.GetInfo());
        }
    }

    public void Dispose()
    {
        foreach (Shop shop in shops)
        {
            shop.Dispose();
        }
        shops.Clear();
        GC.SuppressFinalize(this);
        Console.WriteLine("ShopBase освобождена.");
    }

    ~ShopBase()
    {
        Dispose();
    }
}