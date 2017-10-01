using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer> :
        AbstractExpression,
        IObjectInitializerExpression<TCreateObjectExpression, TExpression, TObjectInitializer>
        where TCreateObjectExpression : ICreateObjectExpression
        where TExpression : IExpression
        where TObjectInitializer : IHasObjectInitializers<TExpression, TObjectInitializer>
    {
        public abstract TCreateObjectExpression CreateObjectExpression { get; }

        public abstract IReadOnlyList<IReadOnlyList<TExpression>> Elements { get; }

        public abstract IReadOnlyDictionary<string, TObjectInitializer> Initializers { get; }

        public abstract IReadOnlyDictionary<string, TExpression> Members { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitObjectInitializerExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitObjectInitializerExpressionChildren(this, visitor);
        }
    }
}
