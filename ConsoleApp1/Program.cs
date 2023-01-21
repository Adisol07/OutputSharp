using OutputSharp;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test";
            Logger.Flags.Add("useType");
            Logger.Flags.Add("typeColor:DarkCyan");
            Logger.AddLog(new Log(new LogPart("[Greeting]", ConsoleColor.Cyan), new LogPart(" Hello World!", ConsoleColor.DarkCyan)));
            Logger.ReadKey();
        }
    }
}