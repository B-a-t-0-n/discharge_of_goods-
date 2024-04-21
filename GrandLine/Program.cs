using GrandLine;
using GrandLine.Data;
using System;
using System.Net.Http.Json;

class Program
{
    public static void Main()
    {
        GrandLineTable grandLine = new GrandLineTable("ca53919db52e201246b7d2a7f5b73753");
        List<Nomenclature> branches = (List<Nomenclature>)grandLine.Nomenclatures;

        if (branches != null)
        {
            foreach (var item in branches)
            {
                Console.WriteLine(item);
                Console.WriteLine("------------------------------------------------------------");
            }
        }
    }
}
