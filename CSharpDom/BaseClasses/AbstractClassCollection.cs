using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        AbstractGenericVisitableObject,
        IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IClass
        where TAbstractClass : IAbstractClass
        where TSealedClass : ISealedClass
        where TStaticClass : IStaticClass
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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassCollectionChildren(this, visitor);
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
