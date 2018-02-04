using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableFinallyStatement<TStatement> : IEditableFinallyStatement, IFinallyStatement<TStatement>
    {
        new IList<TStatement> Statements { get; set; }
    }
}