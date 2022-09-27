using System.Text.RegularExpressions;

namespace Regular
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Завтрак в 23:60";
            Regex regex = new Regex("[0-1]{1}[0-9]{1}:[0-5]{1}[0-9]{1}");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                regex = new Regex("[2]{1}[0-3]{1}:[0-5]{1}[0-9]{1}");
                matches = regex.Matches(s);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        Console.WriteLine(match.Value);
                }
                else
                {
                    Console.WriteLine("Неправильное время");
                }
            }
            Console.ReadLine();
        }
    }
}
