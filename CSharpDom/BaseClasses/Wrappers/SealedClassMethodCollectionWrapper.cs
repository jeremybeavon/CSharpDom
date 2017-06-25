using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class SealedClassMethodCollectionWrapper<TMethod, TExplicitInterfaceMethod> :
        AbstractSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IWrapper<ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>>
        where TMethod : ISealedClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public SealedClassMethodCollectionWrapper(ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }
        
        public override IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods => WrappedObject.ExplicitInterfaceMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}
