using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> :
        IObjectInitializerExpression,
        IHasObjectInitializers<TExpression, TObjectInitializer>
        where TCreateObjectExpression : ICreateObjectExpression
        where TExpression : IExpression
        where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
    {
        TCreateObjectExpression CreateObjectExpression { get; }
    }
}
