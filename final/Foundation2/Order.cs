using System;
using System.Collections.Generic;
using System.Linq;


class Order
{
    List<Product>  _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    //Getters and Setters   
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    
    //Product product1 = new Product();
    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
    
    public float CalculateTotalCostOrder()
    {   
        Console.WriteLine("");    
        float total = 0;
        
        foreach (Product product in _products)
        {
            total += product.ProductPrice(); 
        }
        if (_customer.USACountry())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        
        Console.WriteLine($"Making a total of ${total} (Shipping cost: $5 for the USA and $35 for out USA)");
        
        return total;  
        
        
    }

    public string PackingLabel()
    {
        
        
        string label = "";
        
        if (_products.Count > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Packing Label: (price is based in price * quantity) ");
            Console.WriteLine("");
            foreach(Product product in _products)
            {
                
                label =  product.DisplayProductIDAndName();
                //Console.WriteLine($"{_products} {_products.GetProductID()} {_products.GetProductName()}");
            }
        }

        return label;
         
    }
    
    public string ShippingLabel()
    {
        _customer.DisplayShipingLabel();
        return "";
        
    }



}