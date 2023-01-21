using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSharp
{
    public static class Details
    {
        public static string Version { get; } = "1.0.0";
        public static string Snapshot { get; } = "002";
        public static string FullVersion { get; } = Version + "-" + Snapshot;
        public static string CountVersion { get; } = "3";
        public static string OneDigitVersion { get; } = "1";
    }
}
