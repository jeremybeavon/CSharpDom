using System.Collections.Generic;

namespace CSharpDom.TestTarget.Statements
{
    public sealed class YieldReturnStatement
    {
        public IEnumerable<int> TestYieldReturnBreak()
        {
            yield return 0;
        }
    }
}
