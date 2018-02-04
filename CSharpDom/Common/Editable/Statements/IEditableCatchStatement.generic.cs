using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableCatchStatement<TTypeReference, TStatement> :
        IEditableCatchStatement,
        ICatchStatement<TTypeReference, TStatement>
        where TTypeReference : IEditableTypeReference
        where TStatement : IEditableStatement
    {
        new TTypeReference Type { get; set; }

        new string VariableName { get; set; }

        new IList<TStatement> Statements { get; set; }
    }
}