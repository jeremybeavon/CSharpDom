using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class StructMethodCollectionWrapper<TMethod, TExplicitInterfaceMethod> :
        AbstractStructMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IWrapper<IStructMethodCollection<TMethod, TExplicitInterfaceMethod>>
        where TMethod : IStructMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public StructMethodCollectionWrapper(IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IStructMethodCollection<TMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }
        
        public override IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods => WrappedObject.ExplicitInterfaceMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}
