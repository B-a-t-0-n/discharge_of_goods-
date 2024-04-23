using GrandLineLib;

class Program
{
    public static void Main()
    {
        GrandLine grandLine = new GrandLine("ca53919db52e201246b7d2a7f5b73753");



        foreach (var item in grandLine.Nomenclatures!)
        {
            Console.WriteLine(item.full_name);
            Console.WriteLine("------------------------------------------------------------");
        }
        Console.WriteLine(grandLine.Nomenclatures.Count);
    }
}
