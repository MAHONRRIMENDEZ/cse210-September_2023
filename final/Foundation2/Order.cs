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

    public int CalculateTotalCostOrder()
    {
        int sum = 0;
        foreach (Product product in _products)
        {
        int sum = 0 + product._price;
        }
        return sum;
    }

    public string PackingLabel()
    {
        return"";
    }
    public string ShippingLabel()
    {
        /*if (USA = True)
        {
            int shipingcost = $5;
        } */
        return ""; 
    }



}