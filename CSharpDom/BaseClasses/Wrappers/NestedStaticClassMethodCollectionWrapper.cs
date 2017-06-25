using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedStaticClassMethodCollectionWrapper<TMethod> :
        AbstractNestedStaticClassMethodCollection<TMethod>,
        IWrapper<INestedStaticClassMethodCollection<TMethod>>
        where TMethod : IStaticClassMethod
    {
        public NestedStaticClassMethodCollectionWrapper(INestedStaticClassMethodCollection<TMethod> methods)
        {
            WrappedObject = methods;
        }

        public INestedStaticClassMethodCollection<TMethod> WrappedObject { get; private set; }
        
        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}
