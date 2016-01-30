using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;

namespace CSharpDom.Serialization.Factories
{
    public abstract class AbstractFactory<TInput, TOutput> : AbstractGenericVisitor
        where TInput : IVisitable<IGenericVisitor>
        where TOutput : TInput
    {
        protected AbstractFactory(TInput input)
        {
            if (input != null)
            {
                input.Accept(this);
            }
        }

        public TOutput Value { get; protected set; }

        public sealed override void Visit(IVisitable<IGenericVisitor> node)
        {
            throw new InvalidOperationException();
        }
    }
}
