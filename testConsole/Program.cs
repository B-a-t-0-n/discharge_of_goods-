using DockeLib;
using DockeLib.Exel;

Docke docke = new Docke("kopytina@everestkrov.ru_1", "zx33cvbn");

await docke.UpdateAll(docke.Agrees[0].uuid!, docke.Factories[0].uuid!, 5000, true);

Console.WriteLine(docke.Products.Count + "(P)");
Console.WriteLine(docke.PricesRRP.Count + "(RRP)");
Console.WriteLine(docke.Prices.Count + "($)");

//DockeTableExel dockeTableExel = new(docke);

//dockeTableExel.CreateTable("C:\\Users\\vlakn\\OneDrive\\Рабочий стол\\C# progect");