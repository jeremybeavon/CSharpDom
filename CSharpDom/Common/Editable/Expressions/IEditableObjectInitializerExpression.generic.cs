using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> :
        IEditableObjectInitializerExpression,
        IHasEditableObjectInitializers<TExpression, TObjectInitializer>,
        IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>
        where TCreateObjectExpression : IEditableCreateObjectExpression
        where TExpression : IEditableExpression
        where TObjectInitializer : IHasEditableObjectInitializers<TExpression, TObjectInitializer>
    {
        new TCreateObjectExpression CreateObjectExpression { get; set; }
    }
}