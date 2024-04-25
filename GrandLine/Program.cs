using GrandLineLib;

class Program
{
    public static void Main()
    {
        GrandLine grandLine = new GrandLine("ca53919db52e201246b7d2a7f5b73753");
        GrandLineTableExel grandLineTable = new GrandLineTableExel(grandLine);

        grandLineTable.UpdateProducts();

        Console.WriteLine(">>><<<");


        
    }
}
