using System;
using System.Net.Http.Json;

class Program
{
    
    static HttpClient httpClient = new HttpClient();

    public static async Task Main()
    {
        List<Branches>? branches = await httpClient.GetFromJsonAsync<List<Branches>>($"https://client.grandline.ru/api/public/branches/?api_key=ca53919db52e201246b7d2a7f5b73753");
        if (branches != null)
        {
            foreach (var item in branches)
            {
                Console.WriteLine($"{item.Id1c}\n{item.Code1c}\n{item.Name}\n{item.Address}\n{item.Description}");
                await Console.Out.WriteLineAsync("------------------------------------------------------------");
            }
        } 
    }
}

public class Branches
{
    public string Id1c { get; set; } = "";
    public string Code1c { get; set; } = "";
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Description{ get; set; } = "";
}