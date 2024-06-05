using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        List<int> listInt = new List<int>() { 2, 3, 4, 11,5, 6, 7, 8, 9,300, 500,100 };
        List<string> listString = new List<string>() { null, "T1", "T2", "T3", null };
        List<string> listNull = new List<string>();

        var Sodautienlonhon5 = listInt.FirstOrDefault(x => x % 2 == 0 && x > 5);
        if (Sodautienlonhon5 != 0)
        {
            Console.WriteLine("Số chẵn đầu tiên lớn hơn 5 trong danh sách là: "+ Sodautienlonhon5);
        }
        var Phantucuoicung = listInt.LastOrDefault(x => x > 200);
        Console.WriteLine("Phan tu cuoi cung lon hon 200 la: "+  Phantucuoicung);

        string Phantudautien = listString.FirstOrDefault(x => x != null && x.StartsWith("T"));
        Console.WriteLine("Phần tử đầu tiên có giá trị bắt đầu bằng kí tự T: "+ Phantudautien);

        var So = listInt.Where((x, index) => index %2 !=0 && x %2 ==0).Sum();
        
        
        Console.WriteLine("Tổng giá trị các số ở vị trí lẻ và chia hết cho 2 là: " + So);

    }
}