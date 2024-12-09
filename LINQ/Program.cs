namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameName = new List<string>()
            {
                "Mario",
                "Jumanji",
                "Terminator",
                "Circus",
                "boom",
                "Halo Reach",
                "SipderMan"
            };
            gameName.OrderBy(gameName => gameName.Length).ToList()
                .ForEach(game => Console.WriteLine(game)); 
            
        }
    }
}
    