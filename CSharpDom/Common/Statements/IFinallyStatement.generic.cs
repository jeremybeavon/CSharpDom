using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface IFinallyStatement<TStatement> : IFinallyStatement
    {
        IReadOnlyList<TStatement> Statements { get; }
    }
}
