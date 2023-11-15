namespace HvaGjørDenneKodenOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int totalLetters = 0;

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToUpper();

                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                    totalLetters++;
                }

                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        float percentage = 100f * counts[i] / totalLetters;
                        string percentageFormatted = percentage.ToString("0.00") + "%";

                        var output = $"{character} - {percentageFormatted}";

                        Console.SetCursorPosition(Console.WindowWidth - output.Length, Console.CursorTop);
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}
