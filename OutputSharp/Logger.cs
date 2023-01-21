using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSharp
{
    public static class Logger
    {
        public static List<string> Flags { get; set; } = new List<string>();

        public static void AddLog(Log log)
        {
            if (Flags.Contains("useType"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                foreach (string flag in Flags)
                {
                    if (flag.StartsWith("typeColor:"))
                    {
                        string color = flag.Replace("typeColor:", null).ToLower();
                        switch (color)
                        {
                            case "white":
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "yellow":
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case "blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "green":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "cyan":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case "darkcyan":
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                break;
                            case "black":
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                        }
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
