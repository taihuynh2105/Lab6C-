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
        List<int> list1 = new List<int>() {1,2,3,4,5,6 };
        List<int> list2 = new List<int>() {5,6,7,8,1 };

        var unionDescending = list1.Union(list2).OrderByDescending (x => x);
        foreach (var item in unionDescending)
        {
            Console.WriteLine("Giá trị giảm dần: " + item);
        }
        Console.WriteLine("\n Intersect: ");
        var intersect = list1.Intersect(list2);
        foreach (var item in intersect)
        {
            Console.WriteLine(item + "");
        }
        var concat = list1.Concat(list2).Distinct().OrderBy(x => x);
        Console.WriteLine("\n Concat: ");
        foreach (var item in concat)
        {
            Console.WriteLine(item+ " ");
        }
        var except = list1.Except(list2);
        Console.WriteLine("\n Except: ");
        foreach(var item in except)
        {
            Console.WriteLine(item + " ");
        }
    }
    }