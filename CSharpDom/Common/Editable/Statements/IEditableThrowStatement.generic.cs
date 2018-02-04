using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableThrowStatement<TExpression> : IEditableThrowStatement, IThrowStatement<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }
    }
}