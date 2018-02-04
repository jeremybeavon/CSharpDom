using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableForStatement<TExpression, TForInitializerStatement, TStatement> :
        IEditableForStatement,
        IForStatement<TExpression, TForInitializerStatement, TStatement>
        where TExpression : IEditableExpression
        where TForInitializerStatement : IEditableForInitializerStatement
        where TStatement : IEditableStatement
    {
        new TForInitializerStatement InitialValueStatement { get; set; }

        new TExpression Condition { get; set; }

        new ICollection<TExpression> IncrementExpressions { get; set; }

        new TStatement Statement { get; set; }
    }
}