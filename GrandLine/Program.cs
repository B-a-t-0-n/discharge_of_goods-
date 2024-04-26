using GrandLineLib;

class Program
{
    public static void Main()
    {
        GrandLine grandLine = new GrandLine("ca53919db52e201246b7d2a7f5b73753", true);
        Console.WriteLine(grandLine.Nomenclatures!.Count);
        Console.WriteLine(grandLine.Prices!.Count);
        GrandLineTableExel grandLineTable = new GrandLineTableExel(grandLine);

        //grandLineTable.CreateTable("C:\\Users\\vlakn\\OneDrive\\Рабочий стол\\C# progect\\Console\\GrandLine\\zxc.xlsx");

        Console.WriteLine(">>><<<");


        
    }
}
