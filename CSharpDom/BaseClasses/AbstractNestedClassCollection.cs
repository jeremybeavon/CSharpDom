using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : INestedClass
        where TAbstractClass : INestedAbstractClass
        where TSealedClass : INestedSealedClass
        where TStaticClass : INestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public abstract IReadOnlyCollection<TAbstractClass> AbstractClasses { get; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count + PartialClasses.Count; }
        }

        public abstract TPartialClassCollection PartialClasses { get; }

        public abstract IReadOnlyCollection<TSealedClass> SealedClasses { get; }

        public abstract IReadOnlyCollection<TStaticClass> StaticClasses { get; }

        protected abstract IReadOnlyCollection<TClass> Classes { get; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedClassCollection(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedClassCollectionChildren(this, visitor);
        }

        public IEnumerator<TClass> GetEnumerator()
        {
            return Classes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
