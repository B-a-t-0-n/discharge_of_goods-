using GrandLineLib;
using GrandLineLib.Data;
using System;
using System.Net.Http.Json;

class Program
{
    public static void Main()
    {
        GrandLine grandLine = new GrandLine("ca53919db52e201246b7d2a7f5b73753");
        foreach (var item in grandLine.Prices!)
        {
            Console.WriteLine(item);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
