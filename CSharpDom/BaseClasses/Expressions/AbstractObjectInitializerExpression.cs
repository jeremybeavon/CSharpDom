using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> :
        IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>
        where TCreateObjectExpression : ICreateObjectExpression
        where TExpression : IExpression
        where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
    {
        public abstract TCreateObjectExpression CreateObjectExpression { get; }

        public abstract IReadOnlyList<IReadOnlyList<TExpression>> Elements { get; }

        public abstract IReadOnlyDictionary<string, TObjectInitializer> Initializers { get; }

        public abstract IReadOnlyDictionary<string, TExpression> Members { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitObjectInitializerExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitObjectInitializerExpressionChildren(this, visitor);
        }
    }
}
