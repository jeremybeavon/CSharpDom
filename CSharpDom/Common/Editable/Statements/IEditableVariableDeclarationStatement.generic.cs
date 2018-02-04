using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableVariableDeclarationStatement<TTypeReference, TExpression> :
        IEditableVariableDeclarationStatement,
        IVariableDeclarationStatement<TTypeReference, TExpression>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        new TTypeReference Type { get; set; }

        new IList<TExpression> Expressions { get; set; }
    }
}