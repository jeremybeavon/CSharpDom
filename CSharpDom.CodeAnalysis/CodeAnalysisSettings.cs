using System;

namespace CSharpDom.CodeAnalysis
{
    public static class CodeAnalysisSettings
    {
        internal static bool AreEditsAllowed { get; set; }

        public static IDisposable AllowEdits()
        {
            return new DisposableValue();
        }
        
        private sealed class DisposableValue : IDisposable
        {
            private readonly bool areEditsAllowed;

            public DisposableValue()
            {
                areEditsAllowed = AreEditsAllowed;
                AreEditsAllowed = true;
            }

            public void Dispose()
            {
                AreEditsAllowed = areEditsAllowed;
            }
        }
    }
}
