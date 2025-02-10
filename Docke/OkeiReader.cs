using DockeLib.Data;
using Newtonsoft.Json;

namespace DockeLib
{
    public class OkeiReader
    {
        public static List<OkeiEntry> ReadOkeiEntries(string filePath)
        {
            try
            {
                var jsonData = File.ReadAllText(filePath);
                var okeiEntries = JsonConvert.DeserializeObject<List<OkeiEntry>>(jsonData) ?? [];
                return okeiEntries;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading OKEI JSON file: {ex.Message}");
                return new List<OkeiEntry>();
            }
        }
    }
}
