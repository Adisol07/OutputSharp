using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSharp
{
    /// <summary>
    /// Class for making log from multiple log parts
    /// </summary>
    public class Log
    {
        public string? ID { get; } = Guid.NewGuid().ToString();
        public List<LogPart>? LogParts { get; set; } = new List<LogPart>();
        public string? Type { get; set; } = "INFO";

        public Log(params LogPart[] parts) 
        { LogParts = parts.ToList(); }

        public override string ToString()
        {
            string msg = "";
            foreach (var part in LogParts)
            {
                msg += part.Text;
            }
            return "[" + Type + "] " + msg;
        }
    }
    /// <summary>
    /// Class for making part of the log
    /// </summary>
    public class LogPart
    {
        public string? Text { get; set; }
        public ConsoleColor Color { get; set; }

        public LogPart(string text, ConsoleColor color)
        { Text = text; Color = color; }
    }
}
