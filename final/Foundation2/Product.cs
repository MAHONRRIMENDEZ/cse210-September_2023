using System;
using System.Security.Cryptography.X509Certificates;

class Product
{

    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

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
    /*
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
    */
 
    public int productPrice()
    {
        return _price * _quantity;
    }

}