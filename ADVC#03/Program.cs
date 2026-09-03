using static System.Net.Mime.MediaTypeNames;

namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Quetions1 
            //List<int> grads = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine(grads.Count);
            //Console.WriteLine(grads.First());
            //Console.WriteLine(grads.Last());
            //grads.Sort();
            //Console.WriteLine(string.Join(", ", grads));
            //Console.WriteLine(grads.Find(x => x > 90));
            //Console.WriteLine(string.Join(", ", grads.FindAll(x => x < 75)));
            //Console.WriteLine(grads.RemoveAll(x => x < 75));
            //Console.WriteLine(grads.Any(x => x == 100));
            //List<string> newGrads = grads.Select(x => $"Grade: {x}").ToList();
            //Console.WriteLine(string.Join(", ", newGrads));

            #endregion
            #region Quetions2
            //  SortedDictionary<int,string> players=new SortedDictionary<int,string>();
            //  {
            //      players.Add(500, "Ahmed");
            //      players.Add(200, "Sare");
            //      players.Add(800, "Ali");
            //      players.Add(350, "Mona");
            //  }
            //foreach(var player in players)
            //  {
            //      Console.WriteLine($"{player.Key}, {player.Value}");
            //  }
            //  Console.WriteLine(players.First());
            //  Console.WriteLine(players.Any(x=>x.Key==500));
            //  if (players.TryGetValue(900, out string? value))
            //  {
            //      Console.WriteLine($"Found player: {value}");

            //  }
            //  else
            //  {
            //      Console.WriteLine("Player with score 900 was not found");
            //  }
            //  players.Remove(200);
            //  foreach (var player in players)
            //  {
            //      Console.WriteLine($"{player.Key}, {player.Value}");
            //  }


            #endregion
            #region Quetions3
            //Dictionary<string, string> players2 = new Dictionary<string, string>()
            //{
            //    ["Ahmed"] = "0112890031",
            //    ["Sara"] = "0112890032",
            //    ["Ali"] = "0112890033",
            //    ["Mona"] = "0112890034",
            //};
            //players["Mahmoud"]= "0112890035";
            //foreach(string layer in players.Keys)
            //{
            //    Console.WriteLine($"Player: {layer}, Phone: {players[layer]}");
            //}
            ////players.Add("Ahmed", "0112890031" );
            //players.TryAdd("Ahmed", "0112890031");
            //bool isFound = players.ContainsKey("Hassan");
            //Console.WriteLine($"Is Hassan in phonebook? {isFound}");
            //Console.WriteLine(players.GetValueOrDefault("Hassan", "Not Found"));
            //Console.WriteLine($"All playres: {string.Join(", ", players.Keys)}");
            //Console.WriteLine($"All playres: {string.Join(", ", players.Values)}");


            #endregion
            #region Quetions4

            //HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //Emails.Add("ahmed@test.com");
            //Emails.Add("AHMED@test.com");
            //Emails.Add("sara@test.com");
            //Emails.Add("SARA@test.com");

     
            //Console.WriteLine(Emails.Count());
            ////Now, StringComparer.OrdinalIgnoreCase prevents duplicates.
            //Console.WriteLine("----------------------------------------------------------");
            //HashSet<int> setA = [1, 2, 3,4,5];
            //HashSet<int> setB = [4, 5, 6, 7, 8];
            //var unionSet = setA.Union(setB);
            //Console.WriteLine(string.Join(", ", unionSet));
            //var insIntersectWith = setA.Intersect(setB);
            //Console.WriteLine(string.Join(", ", insIntersectWith));
            //var exceptSet = setA.Except(setB);
            //Console.WriteLine(string.Join(", ", exceptSet));

            //HashSet<int> subset = new HashSet<int> { 1, 2 };
            //var isSubset = subset.IsSubsetOf(setA);
            //Console.WriteLine($"Is subset a subset of setA? {isSubset}");




            #endregion

        }
    }
}