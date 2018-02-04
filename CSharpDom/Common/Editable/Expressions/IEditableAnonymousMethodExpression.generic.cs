using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableAnonymousMethodExpression<TParameter, TStatement> :
        IEditableAnonymousMethodExpression,
        IAnonymousMethodExpression<TParameter, TStatement>
        where TParameter : IEditableAnonymousMethodParameter
        where TStatement : IEditableStatement
    {
        new IList<TParameter> Parameters { get; set; }

        new TStatement Body { get; set; }
    }
}