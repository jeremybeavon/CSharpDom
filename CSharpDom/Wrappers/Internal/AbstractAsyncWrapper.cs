﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    internal abstract class AbstractAsyncWrapper<TInput> : AbstractWrapper
        where TInput : IAsyncVisitable<IGenericVisitor>
    {
        protected AbstractAsyncWrapper(TInput input)
            : base(input)
        {
            if (input != null)
            {
                input.AcceptAsync(this).Wait();
            }
        }

        public sealed override Task VisitAsync(IAsyncVisitable<IGenericVisitor> node)
        {
            throw new InvalidOperationException();
        }
    }
}
