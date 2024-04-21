using GrandLine;
using GrandLine.Data;
using System;
using System.Net.Http.Json;

class Program
{
    public static void Main()
    {
        GrandLine.GrandLine grandLine = new GrandLine.GrandLine("ca53919db52e201246b7d2a7f5b73753");
        foreach (var item in grandLine.Banches!)
        {
            Console.WriteLine(item);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
