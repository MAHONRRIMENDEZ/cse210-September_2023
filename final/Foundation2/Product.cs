using System;
using System.Security.Cryptography.X509Certificates;

class Product
{
     

    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string productName, int productID, int price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    //Getters and Setters
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public void SetProductID(int productID)
    {
        _productID = productID;
    }
    
    public int GetPrice()
    {
        return _price;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    
 
    public float ProductPrice()
    {
        return _price * _quantity;
    }

    public string DisplayProductIDAndName()
    {
        
        Console.WriteLine($"Product Name: {_productName} - Product ID: {_productID} - ${ProductPrice()} ");
        return "";
    }

}