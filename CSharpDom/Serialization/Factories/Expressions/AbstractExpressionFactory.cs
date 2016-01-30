using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public abstract class AbstractExpressionFactory<TInput, TOutput> : AbstractGenericExpressionVisitor
        where TInput : IVisitable<IGenericExpressionVisitor>
        where TOutput : TInput
    {
        protected AbstractExpressionFactory(TInput input)
        {
            if (input != null)
            {
                input.Accept(this);
            }
        }

        public TOutput Value { get; protected set; }

        public sealed override void Visit(IVisitable<IGenericExpressionVisitor> node)
        {
            throw new InvalidOperationException();
        }
    }
}
