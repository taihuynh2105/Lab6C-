using System;
using System.Collections;
using System.Collections.Generic;

public class PhoneLab6
{
    public int id;
    public int shop_id;
    public string name;
    public int price;
    public string des;

    public PhoneLab6(int id, int shop_id, string name, int price, string des)
    {
        this.id = id;
        this.shop_id = shop_id;
        this.name = name;
        this.price = price;
        this.des = des;
    }
}

public class ShopLab6
{
    public int id;
    public string name;
    public string des;

    public ShopLab6(int id, string name, string des)
    {
        this.id = id;
        this.name = name;
        this.des = des;
    }
}

public class Program
{
    public static void Main()
    {
        List<ShopLab6> listShop = new List<ShopLab6>();
        listShop.Add(new ShopLab6(1, "HCM", "Quận 12"));
        listShop.Add(new ShopLab6(2, "Hà Nội", "Quận Nam từ liêm"));
        listShop.Add(new ShopLab6(3, "Đà nẵng", "Quận Hải châu"));

        List<PhoneLab6> listPhone = new List<PhoneLab6>();
        listPhone.Add(new PhoneLab6(1, 1, "IP 15", 100, "độc lạ bình dương"));
        listPhone.Add(new PhoneLab6(2, 1, "IP 16", 10000, "độc lạ bình dương"));
        listPhone.Add(new PhoneLab6(3, 2, "IP 17", 100000, "độc lạ bình dương"));
        listPhone.Add(new PhoneLab6(4, 3, "IP 18", 1000000, "độc lạ bình dương"));

        var querry = from shop in listShop
                     join phone in listPhone on shop.id equals phone.shop_id
                     select new
                     {
                         ShopName = shop.name,
                         PhoneName = phone.name
                     };

        foreach (var item in querry)
        {
            Console.WriteLine($"Shop Name: {item.ShopName}, Phone Name: {item.PhoneName}");
        }

        var resultb = listShop.GroupJoin(listPhone, shop => shop.id, phone => phone.shop_id, (shop, phone) =>
        new
        {
            ShopName = shop.name,
            Phone =phone
        }
        );
        foreach (var group in resultb)
        {
            Console.WriteLine($"ShopName: {group.ShopName}");
            Console.WriteLine("------------------");
            foreach (var phone in group.Phone)
            {
                Console.WriteLine($"phoneName: {phone.name}");
                Console.WriteLine($"phonePrice: {phone.price}");
            }
            Console.WriteLine("------------------");
        }


    }

}