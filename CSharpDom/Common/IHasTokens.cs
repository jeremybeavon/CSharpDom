using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasTokens
    {
        IReadOnlyList<IToken> Tokens { get; }
    }
}
