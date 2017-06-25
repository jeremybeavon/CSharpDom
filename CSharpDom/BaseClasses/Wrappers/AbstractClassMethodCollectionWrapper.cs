using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class AbstractClassMethodCollectionWrapper<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        AbstractAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>,
        IWrapper<IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>>
        where TMethod : IClassMethod
        where TAbstractMethod : IAbstractMethod
        where TExplicitInterfaceMethod : IExplicitInterfaceMethod
    {
        public AbstractClassMethodCollectionWrapper(IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }

        public override IReadOnlyCollection<TAbstractMethod> AbstractMethods => WrappedObject.AbstractMethods;

        public override IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods => WrappedObject.ExplicitInterfaceMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}
