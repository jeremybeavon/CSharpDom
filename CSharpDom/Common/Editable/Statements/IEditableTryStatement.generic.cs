using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableTryStatement<TStatement, TCatchStatement, TFinallyStatement> :
        IEditableTryStatement,
        ITryStatement<TStatement, TCatchStatement, TFinallyStatement>
        where TStatement : IEditableStatement
        where TCatchStatement : IEditableCatchStatement
        where TFinallyStatement : IEditableFinallyStatement
    {
        new IList<TStatement> TryStatements { get; set; }

        new ICollection<TCatchStatement> CatchStatements { get; set; }

        new TFinallyStatement FinallyStatement { get; set; }
    }
}