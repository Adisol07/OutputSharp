using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSharp
{
    /// <summary>
    /// Static class for logging logs to console
    /// </summary>
    public static class Logger
    {
        public static List<string> Flags { get; set; } = new List<string>();

        public static void AddLog(Log log)
        {
            if (Flags.Contains("useType") && !Flags.Contains("!useType"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                foreach (string flag in Flags)
                {
                    if (flag.StartsWith("typeColor:"))
                    {
                        string color = flag.Replace("typeColor:", null);
                        Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
                        break;
                    }
                }
                Console.Write("[" + log.Type + "] ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            foreach (var part in log.LogParts)
            {
                Console.ForegroundColor = part.Color;
                Console.Write(part.Text);
            }
            Console.Write('\n');
        }
        public static void AddLog(string message, string type = "INFO") 
        {
            Log log = new Log();
            log.Type = type;
            log.LogParts.Add(new LogPart(message, ConsoleColor.White));
            AddLog(log);
        }
        public static string? ReadText()
        {
            return Console.ReadLine();
        }
        public static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
