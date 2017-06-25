using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class ClassMethodCollectionWrapper<TMethod, TExplicitInterfaceMethod> :
        AbstractClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IWrapper<IClassMethodCollection<TMethod, TExplicitInterfaceMethod>>
        where TMethod : IClassMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public ClassMethodCollectionWrapper(IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IClassMethodCollection<TMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }
        
        public override IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods => WrappedObject.ExplicitInterfaceMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}
