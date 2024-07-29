namespace DockeLib.Data
{
    public class Factories
    {
        public string? uuid { get; set; }
        public string? name { get; set; }

        public override string ToString()
        {
            return name!;
        }
    }
}