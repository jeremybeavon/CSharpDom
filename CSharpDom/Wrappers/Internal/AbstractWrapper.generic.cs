using CSharpDom.Common;
using System;

namespace CSharpDom.Wrappers.Internal
{
    public abstract class AbstractWrapper<TInput> : AbstractWrapper
        where TInput : IVisitable<IGenericVisitor>
    {
        protected AbstractWrapper(TInput input)
            : base(input)
        {
            if (input != null)
            {
                input.Accept(this);
            }
        }
        
        public sealed override void Visit(IVisitable<IGenericVisitor> node)
        {
            throw new InvalidOperationException();
        }
    }
}
