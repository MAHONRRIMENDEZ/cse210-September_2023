using System;

class Program
{
    static void Main(string[] args)
    {
        

        
        
        Address a1 = new Address("123 Flowers St", "Orlando","FL", "USA");
        Customer c1 = new Customer("Mahonrri Mendez", a1);
        c1.SetCustomerName("Mahonrri Mendez");

        Console.WriteLine($"{c1.GetCustomerName()}");
        Console.WriteLine($"{a1.CompleteAddress()}");
                    ///////// /// Name, Code, Price, Quantity
        Product p1 = new Product("table", 5555, 100, 2); 
        Product p2 = new Product("chair", 1111, 50, 6); 
        Product p3 = new Product("desk", 8888, 150, 1); 
        Product p4 = new Product("Pen", 444, 1, 30);

        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);
        
        

        o1.PackingLabel();
        o1.ShippingLabel();
        Console.WriteLine($"${o1.CalculateTotalCostOrder()}");
        Console.WriteLine(""); 
        Console.WriteLine(""); 
        
/////////////////////////////// Customer #2

        Address a2 = new Address("Calle Flores #250 ", "Mexico City","CDMX", "Mexico");
        Customer c2 = new Customer("Jared Mendez", a2);
        c2.SetCustomerName("Jared Perez");

        Console.WriteLine($"{c2.GetCustomerName()}");
        Console.WriteLine($"{a2.CompleteAddress()}");
///////////////////////////// /// Name, Code, Price, Quantity
        Product p5 = new Product("table", 5555, 100, 4); 
        Product p6 = new Product("chair", 1111, 50, 12); 
        Product p7 = new Product("desk", 8888, 150, 5); 
        Product p8 = new Product("Pen", 444, 1, 100);

        Order o2 = new Order(c2);
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.AddProduct(p7);
        o2.AddProduct(p8);
        
        

        o2.PackingLabel();
        o2.ShippingLabel();
        Console.WriteLine($"${o2.CalculateTotalCostOrder()}");
        Console.WriteLine(""); 
        Console.WriteLine(""); 
        

        
        
    }   
}