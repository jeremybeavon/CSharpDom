using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedClassCollectionWrapper<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        AbstractNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IWrapper<INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>>
        where TClass : INestedClass
        where TAbstractClass : INestedAbstractClass
        where TSealedClass : INestedSealedClass
        where TStaticClass : INestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public NestedClassCollectionWrapper(INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> collection)
        {
            WrappedObject = collection;
        }

        public override IReadOnlyCollection<TAbstractClass> AbstractClasses
        {
            get { return WrappedObject.AbstractClasses; }
        }

        public override TPartialClassCollection PartialClasses
        {
            get { return WrappedObject.PartialClasses; }
        }

        public override IReadOnlyCollection<TSealedClass> SealedClasses
        {
            get { return WrappedObject.SealedClasses; }
        }

        public override IReadOnlyCollection<TStaticClass> StaticClasses
        {
            get { return WrappedObject.StaticClasses; }
        }

        public INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> WrappedObject { get; private set; }

        protected override IReadOnlyCollection<TClass> Classes
        {
            get { return WrappedObject; }
        }
    }
}
