class Shop : IDisposable
{
    public string ShopName { get; set; }
    public string ShopAddress { get; set; }
    public string ShopType { get; set; }
    public string ShopID { get; set; }

    public Shop(string shopName, string shopAddress, string shopType, string shopID)
    {
        ShopName = shopName;
        ShopAddress = shopAddress;
        ShopType = shopType;
        ShopID = shopID;
    }

    public string GetInfo()
    {
        return $"Название магазина: {ShopName}\nАдрес: {ShopAddress}\nТип магазина: {ShopType} \nНомер магазина: {ShopID}";
    }

    public void Dispose()
    {
        Console.WriteLine($"Магазин '{ShopName}' по адресу '{ShopAddress}' типа '{ShopType}' номер {ShopID} был освобожден.");
        GC.SuppressFinalize(this);
    }

    ~Shop()
    {
        Dispose();
    }
}