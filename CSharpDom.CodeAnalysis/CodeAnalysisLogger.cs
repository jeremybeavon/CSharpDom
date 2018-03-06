using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public static class CodeAnalysisLogger
    {
        private static readonly List<string> debugLogMessages = new List<string>();
        internal static bool LogDebugMessages;
        
        public static void StartLoggingDebugMessages()
        {
            LogDebugMessages = true;
        }

        public static void StopLoggingDebugMessages()
        {
            debugLogMessages.Clear();
            LogDebugMessages = false;
        }

        public static void LogDebugMessage(string message)
        {
            if (LogDebugMessages)
            {
                debugLogMessages.Add(message);
            }
        }

        public static void LogDebugMessage(Func<string> message)
        {
            if (LogDebugMessages)
            {
                debugLogMessages.Add(message());
            }
        }

        public static string[] GetDebugLogMessages()
        {
            return debugLogMessages.ToArray();
        }
    }
}
