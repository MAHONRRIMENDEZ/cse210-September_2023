using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer();
        c1.SetCustomerName("Mahonrri Mendez");
        c1.NewAddress("123 Flowers St", "Orlando","FL", "USA");

            Order o1 = new Order();
            o1.NewProduct("table", 5555, 100, 2);
            o1.CalculateTotalCostOrder();
            o1.PackingLabel();
            o1.ShippingLabel();

            Order o2 = new Order();
            o2.NewProduct("chair", 1111, 50, 6);
            o1.PackingLabel();
            o1.ShippingLabel();

            Order o3 = new Order();
            o3.NewProduct("desk", 8888, 150, 1);
            o1.PackingLabel();
            o1.ShippingLabel();


    }
}