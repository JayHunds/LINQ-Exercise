namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
        {
            "Rust",
            "BlackOps 2",
            "Elden Ring",
            "Destiny 2",
            "Dark Souls III",
            "Fallout 76",
            "60 seconds",
            "Bloodborne",
            "Uncharted 4: A Thief's End"
        };

            var orderedGames = videoGames.OrderBy(game => game.Length);

            Console.WriteLine("Ordered list of video games by length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
