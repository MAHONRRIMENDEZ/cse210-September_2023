using System;
using System.Collections.Generic;
using System.Linq;


class Order
{
    List<Product>  _products = new List<Product>();
    private string _customer;


    //Getters and Setters   
    public string GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(string customer)
    {
        _customer = customer;
    }

    public void NewProduct(string productName, int productID, int price, int quantity)
    {
        Product product1 = new Product();
        product1.SetProductName(productName);
        product1.SetProductID(productID);
        product1.SetPrice(price);
        product1.SetQuantity(quantity);
        _products.Add(product1);
        float total = product1.ProductPrice();
        Console.WriteLine($" ${total}");
    }
    
    public float CalculateTotalCostOrder()
    {
        float sum = 0;
        
        foreach (Product product in _products)
        {
            sum += product.ProductPrice();
        }
        Console.WriteLine($"{sum}");
        return sum;

        
        
    }

    public string PackingLabel()
    {
        return "";
    }
    
    public string ShippingLabel()
    {
        return ""; 
    }



}