using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IHasObjectInitializers<TExpression, TObjectInitializers>
        where TObjectInitializers : IHasObjectInitializers<TExpression, TObjectInitializers>
    {
        IReadOnlyDictionary<string, TExpression> Members { get; }

        IReadOnlyList<IReadOnlyList<TExpression>> Elements { get; }

        IReadOnlyDictionary<string, TObjectInitializers> Initializers { get; }
    }
}
