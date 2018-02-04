using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IHasEditableObjectInitializers<TExpression, TObjectInitializers> :
        IVisitable<IEditableExpressionVisitor>,
        IHasObjectInitializers<TExpression, TObjectInitializers>
        where TObjectInitializers : IHasEditableObjectInitializers<TExpression, TObjectInitializers>
    {
        new IDictionary<string, TExpression> Members { get; set; }

        new IList<IList<TExpression>> Elements { get; set; }

        new IDictionary<string, TObjectInitializers> Initializers { get; set; }
    }
}