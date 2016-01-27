using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface ITryStatement<TStatement, TCatchStatement, TFinallyStatement> : ITryStatement
        where TStatement : IStatement
        where TCatchStatement : ICatchStatement
        where TFinallyStatement : IFinallyStatement
    {
        IReadOnlyList<TStatement> TryStatements { get; }

        IReadOnlyCollection<TCatchStatement> CatchStatements { get; }

        TFinallyStatement FinallyStatement { get; }
    }
}
