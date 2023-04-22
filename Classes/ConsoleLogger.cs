namespace ParserAliexpressOrderHistoryHar.Classes;

public class ConsoleLogger
{
    public void Log(string text)
    {
        Console.WriteLine($"{DateTime.Now.TimeOfDay}: {text}");
    }

    public void Error(string text)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{DateTime.Now.TimeOfDay}: {text}");
        Console.ForegroundColor = previousColor;
    }

    public void GreenRaw(string text)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ForegroundColor = previousColor;
    }
}