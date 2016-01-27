using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IMethodBody<TStatement> : IMethodBody
    {
        IReadOnlyList<TStatement> Statements { get; }
    }
}
