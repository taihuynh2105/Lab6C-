/*Chúng ta sử dụng phương thức First() để trả về sản phẩm đầu tiên trong danh sách có giá lớn hơn 100.
Sử dụng phương thức LastOrDefault() để trả về sản phẩm cuối cùng trong danh sách.
Nếu danh sách rỗng, phương thức này sẽ trả về giá trị mặc định của kiểu dữ liệu (trong trường hợp này là null). Cuối cùng, chúng ta in ra thông tin của sản phẩm đầu tiên có giá trị > 100 và thông tin của sản phẩm cuối cùng trong danh sách */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name= "Laptop", Price = 1200.50m },
            new Product { Name ="Mouse", Price =19.99m },
            new Product { Name ="Keyboard", Price = 49.99m },
            new Product { Name ="Monitor", Price= 299.99m },
            new Product { Name="Headphones", Price=99.99m }
    };
        // Dùng phương thức First để trả về sản phẩm đầu tiên có giá trị > 100
        var firstExpensiveProduct = products.First(p => p.Price > 100);
        Console.WriteLine("San pham dau tien co gia > 100:");
        Console.WriteLine($"Ten: {firstExpensiveProduct.Name}, Gia: {firstExpensiveProduct.Price}");
        // Dùng phương thức LastOrDefault để trả về sản phẩm cuối cùng
        var lastProduct = products.LastOrDefault();
        if (lastProduct != null)
        {
            Console.WriteLine("\nSan pham cuoi cung: ");
            Console.WriteLine($"Ten: {lastProduct.Name}, Gia: {lastProduct.Price}");
        }
    }
}