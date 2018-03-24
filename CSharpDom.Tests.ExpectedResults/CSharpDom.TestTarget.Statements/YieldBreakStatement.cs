using System.Collections.Generic;

namespace CSharpDom.TestTarget.Statements
{
    public sealed class YieldBreakStatement
    {
        public IEnumerable<int> TestYieldBreak()
        {
            yield break;
        }
    }
}
