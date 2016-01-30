using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;
using System;

namespace CSharpDom.Serialization.Factories.Statements
{
    public abstract class AbstractStatementFactory<TInput, TOutput> : AbstractGenericStatementVisitor
        where TInput : IVisitable<IGenericStatementVisitor>
        where TOutput : TInput
    {
        protected AbstractStatementFactory(TInput input)
        {
            if (input != null)
            {
                input.Accept(this);
            }
        }

        public TOutput Value { get; protected set; }

        public sealed override void Visit(IVisitable<IGenericStatementVisitor> node)
        {
            throw new InvalidOperationException();
        }
    }
}
