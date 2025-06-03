using System;


public static class ConsoleEx
{
    // shame we cant inherit from Console


    public static void Write(ConsoleColor color, string format, params object[] arg)
    {
        var current = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(format, arg);
        Console.ForegroundColor = current;
    }

    public static void WriteLine(string format) =>
     Console.WriteLine(format);


    public static void WriteLine(ConsoleColor color, string format, params object[] arg) =>
        Write(color, $"{format}\n", arg);

    public static void WriteBold(string format, params object[] arg) =>
        Console.Write($"\x1b[1m{format}\x1b[0m", arg);

    public static void WriteLineBold(string format, params object[] arg) =>
       WriteBold($"{format}\n", arg);

           public static void WriteLineBold(ConsoleColor color, string format, params object[] arg) =>
       WriteLine(color,$"\x1b[1m{format}\x1b[0m", arg);
}