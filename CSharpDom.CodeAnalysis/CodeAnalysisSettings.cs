using System;

namespace CSharpDom.CodeAnalysis
{
    internal static class CodeAnalysisSettings
    {
        public static bool SkipRefreshes { get; set; }

        public static IDisposable TemporarilySkipRefreshes()
        {
            return new DisposableValue();
        }

        private sealed class DisposableValue : IDisposable
        {
            private readonly bool skipRefreshes;

            public DisposableValue()
            {
                skipRefreshes = SkipRefreshes;
                SkipRefreshes = true;
            }

            public void Dispose()
            {
                SkipRefreshes = skipRefreshes;
            }
        }
    }
}
