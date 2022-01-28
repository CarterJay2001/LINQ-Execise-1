using System;

namespace LINQExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>(){
            "God of War",
            "Detroit: Become Human",
            "Paper Mario",
            "Watch Dogs 2",
            "Star Wars Battlefront II",
            "Rocket League",
            "Yakuza Kiwami",
            "Cuphead",
            "Red Dead Redemption 2",
            "Super Mario All-Stars" };

            var lengthOrder = games.OrderByDescending(x => x.Length);
            var longerThen6 = games.Where(x => x.Length > 6);
        }
    }
}
