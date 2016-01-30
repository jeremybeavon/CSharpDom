using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories
{
    public abstract class AbstractAsyncFactory<TInput, TOutput> : AbstractGenericVisitor
        where TInput : IAsyncVisitable<IGenericVisitor>
        where TOutput : TInput
    {
        private TInput input;

        protected AbstractAsyncFactory(TInput input)
        {
            this.input = input;
        }

        public async Task<TOutput> ValueAsync()
        {
            if (input != null)
            {
                await input.AcceptAsync(this);
            }

            return Value;
        }

        protected TOutput Value { get; set; }

        public sealed override void Visit(IVisitable<IGenericVisitor> node)
        {
            throw new InvalidOperationException();
        }
    }
}
