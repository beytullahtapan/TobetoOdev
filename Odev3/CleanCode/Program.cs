﻿Customer customer1 = new Customer
{
    Id = 1,
    Name = "Beytullah",
    IsStudent = true,
    IsOfficer = false
};

IProductService productService = new ProductManager(new IsBankServiceAdapter());
productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 }, new Customer { Id = 1, Name = "Beytullah", IsStudent = true, IsOfficer = false });



class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsStudent { get; set; }
    public bool IsOfficer { get; set; }
}

interface IEntity
{
}

class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class ProductManager : IProductService
{
    private IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }
    //Değiştirilen kısım
    public void Sell(Product product, Customer customer)
    {
        decimal price = product.Price;

        if (customer.IsStudent)
        {
            Discount(ref price, 0.1M);
        }
        else if (customer.IsOfficer)
        {
            Discount(ref price, 0.2M);
        }
        price = BaseCurrency(price);
        Console.WriteLine(price);
        Console.ReadLine();
    }
    private void Discount(ref decimal price, decimal discountRate)
    {
        price -= price * discountRate;
    }
    private decimal BaseCurrency(decimal price)
    {
        return _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
    }
}
internal interface IProductService
{
    void Sell(Product product, Customer customer);
}

class FakeBankService : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / 30.67M;
    }
}

internal interface IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate);
}

class CurrencyRate
{
    public decimal Price { get; set; }
    public int Currency { get; set; }
}

class CentralBankServiceAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        CentralBankService centralBankService = new CentralBankService();
        return centralBankService.ConvertRate(currencyRate);
    }
}


//Merkez bankasının kodu gibi düşünün
class CentralBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / 30.58M;
    }
}

//İş bankasının kodu gibi düşünün
class IsBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / 30.55M;
    }
}
class IsBankServiceAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        IsBankService centralBankService = new IsBankService();
        return centralBankService.ConvertRate(currencyRate);
    }
}