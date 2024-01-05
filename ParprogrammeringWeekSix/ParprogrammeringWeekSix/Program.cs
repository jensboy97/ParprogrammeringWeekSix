using ParprogrammeringWeekSix;

class Program
{
    static void Main()
    {
        ClothingItem pants = new ClothingItem("bukser", 20, 49.99m, "L", "Rød");
        var SalePricePants = pants.CalculatePrice();
        ClothingItem shirt = new ClothingItem("T-skjorte", 10, 19.99m, "M", "Blå");
        var SalePriceShirt = shirt.CalculatePrice();
        
        ElectronicItem pc = new ElectronicItem("Laptop", 5, 3999.99m, "2 års garanti", "220V");
        var SalePricePc = pc.CalculatePrice();

        ElectronicItem pc1 = new ElectronicItem("Desktop", 5, 9999.99m, "5 års garanti", "850w");
        var SalePricePc1 = pc1.CalculatePrice();

        ElectronicItem toaster = new ElectronicItem("Brød rister", 1, 1499.99m, "2 års garanti", "220V");
        var SalePriceToaster = toaster.CalculatePrice();

        ElectronicItem phone = new ElectronicItem("Iphone X", 25, 3499.99m, "1 år garanti", "420w");
        var SalePricePhone = phone.CalculatePrice();

        Console.WriteLine($"Toaster price is: {SalePriceToaster}");
        Console.WriteLine($"Pants price is: {SalePricePants}");
        Console.WriteLine($"Deskie price is: {SalePricePc1}");
        Console.WriteLine($"The sale price of the phone is: {SalePricePhone}");
        Console.WriteLine($"Salgs prisen for {shirt.Name}: {SalePriceShirt}");
        Console.WriteLine($"Prisen er nå {pc.Name}: {SalePricePc}");
    }
}