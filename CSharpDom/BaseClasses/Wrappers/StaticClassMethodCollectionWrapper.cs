using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class StaticClassMethodCollectionWrapper<TMethod, TExtensionMethod> :
        AbstractStaticClassMethodCollection<TMethod, TExtensionMethod>,
        IWrapper<IStaticClassMethodCollection<TMethod, TExtensionMethod>>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
    {
        public StaticClassMethodCollectionWrapper(IStaticClassMethodCollection<TMethod, TExtensionMethod> methods)
        {
            WrappedObject = methods;
        }

        public IStaticClassMethodCollection<TMethod, TExtensionMethod> WrappedObject { get; private set; }
        
        public override IReadOnlyCollection<TExtensionMethod> ExtensionMethods => WrappedObject.ExtensionMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}
